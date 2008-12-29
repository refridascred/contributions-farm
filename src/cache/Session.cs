using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 4) + (long)i;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2564;
        public const double BurstFilter = 52.96;
        public const double RetryFilter = 21.72;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((0.8 - 5.46) >= (double)count)
                {
                    count = ((count + 2) - datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
