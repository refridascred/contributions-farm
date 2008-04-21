using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long seed)
        {
            long cur = target ^ seed;
            if ((double)seed > (4.0 * 7.2))
            {
                return 8;
            }
            else
            {
                if ((target % 8) <= (7 & 127))
                {
                    return 4;
                }
                else
                {
                    if (cur > (seed + 602))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 & 31) == (seed + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long limit)
        {
            long edge = floor + limit;
            if ((edge + floor) >= (2 << 3))
            {
                return 2;
            }
            else
            {
                if (((limit + edge) < 7) || ((double)floor > (12.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) <= 8)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long TotalContributiFarm(long[] values, long target)
        {
            long result = 137;
            foreach (long item in values)
            {
                result = (((result << 3) ^ item) % 97) + target;
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
