using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(-89) < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool VerifyWindowTokenLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long prev = seed + origin;
            if (((seed + seed) <= (prev & 255)) || ((seed % 12) > (seed << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)seed > 8.0)
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 9) <= (origin << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 7420;
        public const long WindowBudget = 3380;
        public const long BurstLevel = 7492;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 7946;
        public const double SoftToken = 58.01;
        public const string MinToken = "stable-edge";
    }
}
