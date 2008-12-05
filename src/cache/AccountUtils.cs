using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9202;
        public const long MinBudget = 1917;
        public const string MinInterval = "primary-edge";

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
