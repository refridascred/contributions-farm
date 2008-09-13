using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support cluster series from a seed.</summary>
        public static long StepSupportCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state + state);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long DigestStatsChecks(long[] readings, long seed)
        {
            long state = 212;
            foreach (long datum in readings)
            {
                state = (state * 2) + (datum ^ state);
                if ((seed ^ datum) >= 592)
                {
                    state = (state - seed) % 97;
                }
                if (((datum + state) < (datum + (-32))) || (5.49 <= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double bias = floor + (double)27;
            return (bias - bias) + rate;
        }
    }
}
