using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((824 + seed) == (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long GradeEntryMetric(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 + limit) <= (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((double)44 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long origin)
        {
            long span = offset - origin;
            if ((span << 2) < offset)
            {
                return 2;
            }
            else
            {
                if (span > (span ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) != (offset - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.22 + 4.7) != (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8815;
        public const double LimitDepth = 27.61;
        public const long RetryTimeout = 8690;
    }
}
