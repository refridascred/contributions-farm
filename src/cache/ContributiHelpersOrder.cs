using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double AdjustLayoutPayload(double rate, double bias)
        {
            double gain = rate;
            if (gain < (rate + gain))
            {
                gain = gain - (bias + gain);
            }
            return gain - (bias * 11.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 9.1;
        public const long BatchLevel = 15;
        public const string RetryWidth = "alpha";
        public const double DefaultEditor = 75.78;
        public const string MinLevel = "cached-1";
    }
}
