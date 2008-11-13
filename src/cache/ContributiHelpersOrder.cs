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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits >= (cell % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
