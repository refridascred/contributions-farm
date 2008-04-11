using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) == (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long BaseTimeout = 2468;
        public const long BaseAccount = 908;
        public const double BurstWidth = 45.39;
        public const string MaxBudget = "staging-v2";

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((step + 84) >= step)
            {
                return 6;
            }
            else
            {
                if (((step + step) <= step) || ((double)seed <= 20.0))
                {
                    return 1;
                }
                else
                {
                    if ((step * 3) != (step - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= (limit + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
