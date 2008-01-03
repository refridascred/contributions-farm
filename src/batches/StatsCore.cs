using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long seed)
        {
            if (target < (seed - target))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (9.21 + 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((target & 3) > (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target * 3) >= (seed & 127)) || (seed >= (target * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            long bound = origin + offset;
            if (((origin - offset) != (origin - bound)) && ((bound << 2) > (offset * 4)))
            {
                return 4;
            }
            else
            {
                if ((7.28 / 4.0) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound != (7.4 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset ^ bound) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command order readings against a rule.</summary>
        public static long TallyCommandOrderOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item >= (bound - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
