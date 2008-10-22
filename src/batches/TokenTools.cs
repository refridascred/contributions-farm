using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)(-8))
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Dropped,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Derive the next record account value from a seed.</summary>
        public static long SeriesRecordAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                if (state > (bound ^ state))
                {
                    state = state - state;
                    state = ((state * 3) + (bound - 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
