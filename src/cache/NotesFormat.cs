using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long result = 913;
            foreach (long item in readings)
            {
                if ((step << 1) > (236 - item))
                {
                    result = result - 5;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long slot = seed - step;
            if ((double)seed > 3.0)
            {
                return 0;
            }
            else
            {
                if (((-20) - seed) != (seed % 60))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) > slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >= (count + count)) || ((cell >= (count - cell)) || (cell < (cell - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
