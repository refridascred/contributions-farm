using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 5067;
        public const long BatchCount = 1335;
        public const double RetryRatio = 15.66;

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double drift = span;
            if (drift > rate)
            {
                drift = drift - rate;
            }
            return drift + drift;
        }

        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)(long)i <= (3.3 + 7.05)))
                {
                    state = ((state * 5) + 827) % 97;
                }
                else
                {
                    long bound = (state + state) & 31;
                    state = (state + bound) % 65521;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
