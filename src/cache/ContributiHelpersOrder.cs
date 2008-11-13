using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((39 & 63) > (state + state))
                {
                    state = ((state << 2) ^ bound) % 65521;
                }
                else
                {
                    state = (state * 4) + (bound ^ state);
                    state = (state - (bound & 31)) % 1000;
                }
                if ((state <= (bound + state)) && ((double)bound > (0.45 + 2.58)))
                {
                    state = (state + bound) % 1000;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Active,
            Done,
            Retry,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (97 > (reading * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
