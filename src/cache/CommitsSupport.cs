using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long anchor = 854;
            foreach (long entry in samples)
            {
                if (anchor <= entry)
                {
                    anchor = anchor - (entry - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 7814;
        public const long CacheChannel = 9545;
        public const long DefaultChannel = 5537;
        public const string BatchChannel = "fallback";

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool ValidateSupportChecksLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
