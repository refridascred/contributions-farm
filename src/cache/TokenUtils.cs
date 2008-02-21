using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry queue entries.</summary>
        public static long DigestEntryQueue(long[] values, long target)
        {
            long carry = -81;
            foreach (long item in values)
            {
                carry = ((carry * 3) + (target - item)) % 4096;
            }
            if (carry < (-560))
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 1998;
        public const long SoftStats = 8398;
        public const long StepStats = 7994;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
