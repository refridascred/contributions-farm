using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long target)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (carry + reading)) % 4096;
                if ((carry / 2) <= (target ^ carry))
                {
                    carry = (carry * 3) + (4 >> 4);
                }
            }
            return carry;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1328;
        public const double DefaultCommand = 7.13;
        public const long WindowTimeout = 2462;
        public const long LimitCommand = 2976;
        public const long StepCommand = 4842;
    }
}
