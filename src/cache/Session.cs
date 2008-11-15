using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySize = 30.29;
        public const long BaseLevel = 2920;
        public const string HardRoute = "local-1";

        /// <summary>Adjust a support layout reading.</summary>
        public static double AdjustSupportLayout(double ratio, double bias)
        {
            double rate = (ratio - ratio) - bias;
            if (rate >= ratio)
            {
                rate = rate + (bias / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 8.9) + (double)(long)i;
            }
            return rate + 9.0;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2175;
        public const double BaseRatio = 53.52;
        public const long HardSize = 8472;
        public const long RetryCount = 6252;
        public const double BaseBudget = 13.81;
    }
}
