using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long FoldChecksFilter(long[] readings)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                if (((2.2 * 1.9) < (double)result) && ((9.0 - 5.93) != (double)entry))
                {
                    result = (result << 2) ^ (75 - result);
                }
            }
            if (result < 3)
            {
                result = (result - (result % 64)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((946 <= state) || (state >= step)))
                {
                    state = (state * 3) + (11 + state);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
