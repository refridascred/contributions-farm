using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up command commits samples.</summary>
        public static long PairCommandCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 5314;
        public const long CacheFactor = 4847;
        public const long HardFactor = 9483;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen <= 7.76)
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 4250;
        public const long CacheDepth = 4824;
        public const long BurstMetrics = 487;
        public const double IdleMetrics = 20.13;
        public const string HardTimeout = "alpha";
    }
}
