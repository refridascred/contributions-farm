using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string DefaultTimeout = "cached-1";
        public const long HardCount = 4501;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 2054;
        public const long SoftMetrics = 7746;
        public const string BurstMetrics = "fallback-edge";
        public const long IdleMetrics = 6563;

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((double)origin != (8.39 / 9.0)) && ((result >> 1) == ((long)i - result)))
                {
                    result = (result ^ result) % 255;
                    result = ((result << 2) ^ (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading - 4) <= (floor - (long)levels.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
