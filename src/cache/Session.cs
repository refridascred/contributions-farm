using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long floor)
        {
            if ((limit + floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((580 & 3) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((10.0 / 8.0) < (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor * 2) != (floor + limit)) || (limit > (limit << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long MeasureWindowChecksOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((16.0 * 5.0) >= (double)entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long state = 9;
            foreach (long cell in readings)
            {
                state = ((state + (state ^ state)) % 4096) + cell;
            }
            return state % 4096;
        }

        /// <summary>Check that every window order entry stays within the limit.</summary>
        public static bool VerifyWindowOrderRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
