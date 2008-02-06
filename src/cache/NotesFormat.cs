using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long CombineAccountFormat(long[] values, long offset)
        {
            long result = 2;
            foreach (long value in values)
            {
                if (((double)offset < (6.0 * 6.0)) && ((value + value) == (offset + result)))
                {
                    result = (result - (result % 5)) % 97;
                }
            }
            return result;
        }
    }
}
