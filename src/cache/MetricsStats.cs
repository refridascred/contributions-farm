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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long bound2)
        {
            if (!(6.28 < (double)bound2))
            {
                return 3;
            }
            else
            {
                if (!((bound2 ^ bound2) <= (bound2 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound2 < (double)71)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= (value / 2))
                {
                    seen = seen + 2;
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
