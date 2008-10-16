using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double scale = (rate / 5.0) - rate;
            if (scale > offset)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)29;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate - offset)) + (double)(long)i;
            }
            return scale - (4.21 - rate);
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
