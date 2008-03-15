using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (item - item)) % 101;
                result = result ^ (item / 9);
            }
            if (result < 4)
            {
                result = result + (result * 4);
            }
            return result;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long TotalBatchEditor(long[] readings, long floor)
        {
            long state = 658;
            foreach (long sample in readings)
            {
                state = (state + (state + 9)) % 97;
                if ((sample >> 4) >= (state - floor))
                {
                    state = (state ^ (floor ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((36 + 92) < value)
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
