using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (floor >= (reading & 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((offset & 7) >= (sample - offset)) && ((double)offset <= (10.0 + 6.6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            long cur = step ^ floor;
            if ((step <= floor) && ((1.8 * 3.48) > (double)cur))
            {
                return 2;
            }
            else
            {
                if ((cur + step) == (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (((double)cur <= (double)floor) || ((step & 127) > cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7.1 / 5.0) == (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
