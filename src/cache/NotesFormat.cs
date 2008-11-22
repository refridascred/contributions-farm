using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long offset)
        {
            long state = -5;
            foreach (long item in series)
            {
                state = (state ^ (item * 5)) % 1000;
                if ((789 - state) < ((-551) * 2))
                {
                    state = ((state * 2) + offset) % 255;
                }
                else
                {
                    state = state ^ (item / 5);
                }
                state = state + 831;
                if (((item ^ 28) >= (state << 3)) && (state < (state - item)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a counter already sample.</summary>
        public static long LocateCounterAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
