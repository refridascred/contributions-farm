using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long step)
        {
            if (10 <= (floor >> 1))
            {
                return 5;
            }
            else
            {
                if (((step + step) < (floor + step)) && ((4.0 * 8.0) < (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 4) > 99)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= 60)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 65.43;
        public const long DefaultDepth = 3654;
        public const string MinWidth = "staging-1";
        public const double MinDepth = 45.04;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((944 - hits) <= (cell % 16)) || ((cell + 403) == (hits + 903)))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long CountOrderCacheOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)origin <= (1.0 * 7.9)))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
