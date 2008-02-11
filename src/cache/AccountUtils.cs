using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6110;
        public const long SoftBatches = 9939;
        public const string MinBatches = "alpha";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool VerifyAccountReportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
