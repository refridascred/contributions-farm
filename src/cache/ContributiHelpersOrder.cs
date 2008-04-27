using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            long offset = floor - origin;
            if ((1 >> 5) > (offset + origin))
            {
                return 8;
            }
            else
            {
                if (offset <= floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor >> 4) > offset) && ((9.72 * 2.7) != (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (1.5 * 3.04)) && ((origin << 1) <= (floor & 127)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > 14.0)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
