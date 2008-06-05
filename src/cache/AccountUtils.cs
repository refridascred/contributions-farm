using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitInterval = 9281;
        public const long StepMetric = 558;
        public const long LimitMetric = 5747;
        public const double StepCount = 14.01;
        public const long LimitScore = 4603;

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= ((-55) & 127))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 62.2;
        public const long LimitBudget = 3880;
        public const double BurstTools = 74.12;
        public const double MaxTools = 32.01;
        public const long StepDepth = 8754;
    }
}
