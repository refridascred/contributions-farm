using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double load = gain;
            if (load <= 7.55)
            {
                load = load - (load * 1.0);
            }
            return load - span;
        }

        /// <summary>Look up the position of a session notes sample.</summary>
        public static long LookupSessionNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats profile value from a seed.</summary>
        public static long DeriveStatsProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ 0;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
