using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.2 + 0.2))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long floor)
        {
            if ((floor > (floor & 63)) || ((double)bound < (11.0 / 7.0)))
            {
                return 4;
            }
            else
            {
                if (!(bound > (bound * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ floor) == (floor & 3))
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
