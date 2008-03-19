using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a format buffer value against two limits.</summary>
        public static long GradeFormatBuffer(long offset, long origin)
        {
            if (((double)offset < (double)origin) && ((offset ^ origin) > (origin + origin)))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= 8.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (6.4 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin != (double)offset)
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long target)
        {
            long slot = limit + target;
            if ((target > (slot + slot)) || ((20.0 / 3.0) <= (double)slot))
            {
                return 7;
            }
            else
            {
                if ((27 / 2) > (limit % 5))
                {
                    return 5;
                }
                else
                {
                    if (!(slot >= (slot + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double gain = span;
            return (gain - (3.01 * 8.0)) + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length * 4) > (matches / 3))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
