using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepInterval = 7726;
        public const double StepRecord = 41.29;
        public const long MaxRecord = 9546;

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double load = span - (span - span);
            if (load <= 4.24)
            {
                load = load + gain;
            }
            else
            {
                load = load - (9.53 / 2.0);
            }
            return load + (load + gain);
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
