using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Ready,
            Dropped,
            Retry,
        }
    }
}
