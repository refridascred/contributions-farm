using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate filter session readings against a bound.</summary>
        public static bool GuardFilterSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if ((79 >> 3) >= (floor + floor2))
            {
                return 5;
            }
            else
            {
                if ((764 / 3) == (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if (((9.33 - 9.5) <= (double)floor2) || ((4.0 / 5.0) <= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor << 2) > floor) || ((floor2 + floor) < (floor2 & 255)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset > (2.22 / 8.0))
            {
                return 2;
            }
            else
            {
                if (52 > (step >> 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long FoldCacheChecks(long[] data)
        {
            long score = 104;
            foreach (long item in data)
            {
                score = ((score << 2) ^ (long)data.Length) - item;
            }
            return score % 97;
        }
    }
}
