using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1259;
        public const long StepLayout = 6720;
        public const double StepTimeout = 95.66;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every metric farm entry stays within the limit.</summary>
        public static bool ValidateMetricFarmRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
