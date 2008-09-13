using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstBudget = 3857;
        public const long RetrySupport = 1018;
        public const long BaseSupport = 7101;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)bound > (double)60) && ((datum - bound) > (bound - datum))) && (((bound * 5) < (bound << 3)) && ((tally % 100) > 500)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Draft,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
