using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double gain = (double)(8 >> 5);
            if (gain > 9.9)
            {
                gain = (gain - (double)3) - rate;
            }
            return gain - (span / 6.0);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                state = (state + (state >> 1)) % 4096;
                state = state ^ (state & 127);
                if ((value + value) <= state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 63) != (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
