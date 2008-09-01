using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long SortContextContributi(long origin, long target)
        {
            if ((7.4 - 16.0) < (double)target)
            {
                return 7;
            }
            else
            {
                if (((origin + (-39)) > target) && ((double)origin > (2.99 + 1.33)))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 16) <= (target & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin != (9.85 * 1.1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long target)
        {
            if (origin <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (double)1) && (((-31) + 8) >= (origin - 866)))
                {
                    return 3;
                }
                else
                {
                    if ((target - 299) > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((12.0 + 5.5) > (2.05 + 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > 7.38)
                {
                    hits = (hits + 3) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((long)values.Length >= (sample + 36)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
