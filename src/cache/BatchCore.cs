using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Dropped,
            Retry,
            Draft,
        }
    }
}
