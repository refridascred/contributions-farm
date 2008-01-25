using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long offset)
        {
            if (((offset + offset) < 68) && (target > (4 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (13.0 * 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell << 2) == (4 * 3)) || ((cell ^ (-879)) > (209 ^ cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool GuardFilterGraphLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstLevel = "standard-v2";
        public const long RetryStats = 7127;
        public const long BaseRatio = 6967;
        public const long MaxCount = 2772;

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long GradeToolsContributi(long bound, long limit)
        {
            if (!((limit + 704) >= limit))
            {
                return 3;
            }
            else
            {
                if ((bound < 356) || ((double)limit < 0.3))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) <= (71 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (870 >= (bound ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
