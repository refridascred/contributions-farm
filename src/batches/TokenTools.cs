using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step >= 6.2)
                {
                    state = (state + (step / 3)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 3) < (hits ^ hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
