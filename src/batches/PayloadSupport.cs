using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long offset, long offset2)
        {
            if (((offset / 7) != (496 % 5)) || ((offset2 << 2) != (1 + 32)))
            {
                return 1;
            }
            else
            {
                if (!((offset2 ^ offset2) >= offset2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            long prev = limit - origin;
            if (((prev & 1) > prev) && ((double)origin == (15.0 + 4.83)))
            {
                return 4;
            }
            else
            {
                if ((7.6 * 7.5) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((prev ^ origin) >= prev)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < (3.82 + 9.7)) && (limit < (94 + prev)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) <= reading)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
