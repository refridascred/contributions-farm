using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a window farm sample.</summary>
        public static long LookupWindowFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window farm entry stays within the limit.</summary>
        public static bool ValidateWindowFarmLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)bound > (6.0 + 6.14))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
