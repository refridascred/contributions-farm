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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((14 >= (2 + seen)) && ((seen / 9) > seen)) || (((entry ^ seen) <= entry) || ((entry / 5) >= (entry / 6))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 7946;
        public const double SoftToken = 58.01;
        public const string MinToken = "stable-edge";
    }
}
