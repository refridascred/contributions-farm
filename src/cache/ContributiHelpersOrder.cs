using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double bias, double offset)
        {
            double drift = (bias / 5.0) / 4.0;
            if (drift >= (bias + bias))
            {
                drift = drift + (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = state - floor;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
