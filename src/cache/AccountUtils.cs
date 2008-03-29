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

        /// <summary>Scale a channel record figure with a bias.</summary>
        public static double BlendChannelRecord(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (gain + mean))
            {
                mean = (mean + gain) + floor;
            }
            else
            {
                mean = mean + (mean + gain);
            }
            return mean - gain;
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
