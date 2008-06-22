using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const long MaxInterval = 1025;
        public const long SoftScore = 8342;
        public const long BaseInterval = 3984;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)anchor > (1.3 * 7.11))
                {
                    anchor = (anchor << 3) ^ (target + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
