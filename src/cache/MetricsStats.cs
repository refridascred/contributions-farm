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

        /// <summary>Project the next already tools value.</summary>
        public static double ProjectAlreadyTools(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - (0.98 + ratio2)) - offset;
            }
            return ratio2 - (ratio2 * 1.9);
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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((double)entry == (double)3) || ((5.95 - 9.8) < (double)entry)) || (origin > (origin & 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 7946;
        public const double SoftToken = 58.01;
        public const string MinToken = "stable-edge";
    }
}
