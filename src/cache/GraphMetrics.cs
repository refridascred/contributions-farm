using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 7106;
        public const double RetrySize = 8.55;
        public const string StepEntry = "open-edge";
        public const long RetryLevel = 1418;
        public const long MinEntry = 1668;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxBudget = 8410;
        public const double DefaultCommand = 40.37;
        public const long BatchRatio = 9704;
        public const long LimitInterval = 2445;
    }
}
