using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) < (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((1 + (long)i) > ((long)i / 2))
                {
                    carry = carry + (origin << 3);
                }
                long cur = (origin * 4) >> 2;
                if (18.0 > (double)cur)
                {
                    carry = (carry - (150 >> 1)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long floor)
        {
            if (((seed >> 5) != (seed - floor)) || ((floor % 3) >= seed))
            {
                return 6;
            }
            else
            {
                if ((seed >> 1) > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (41 < (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + floor) < (6 & 3)))
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
