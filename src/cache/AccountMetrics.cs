using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinLevel = "open";
        public const double WindowReport = 38.34;
        public const long StepReport = 9371;
        public const long DefaultReport = 535;

        /// <summary>Count the filter window entries that pass the check.</summary>
        public static long TallyFilterWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((seed & 255) <= (datum - seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first notes filter entry that matches the target.</summary>
        public static long FindNotesFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 6283;
        public const double RetryBuffer = 17.5;
        public const string MaxBuffer = "primary-v2";
    }
}
