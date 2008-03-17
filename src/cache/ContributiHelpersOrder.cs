using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items, long limit)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((double)cell > (8.65 * 5.0))
                {
                    sum = ((sum * 2) + (limit - limit)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 366;
            foreach (long sample in data)
            {
                if (((double)state == (6.0 * 7.2)) && ((double)sample <= (double)state))
                {
                    state = (state - (sample & 1)) % 65521;
                }
            }
            if (state > 972)
            {
                state = ((state * 2) + (state >> 3)) % 255;
            }
            return state % 4096;
        }
    }
}
