using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long seed)
        {
            long bound = limit + seed;
            if (((bound - seed) >= (bound / 2)) && ((double)limit <= 8.7))
            {
                return 2;
            }
            else
            {
                if ((0 + bound) <= (74 ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit - 5) > ((-242) << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "stable-edge";
        public const long WindowTimeout = 5720;
        public const long HardInterval = 9109;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 7) <= (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
