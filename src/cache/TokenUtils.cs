using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepInterval = "standard-edge";
        public const double BaseSession = 90.06;
        public const double SoftBudget = 75.87;
        public const long CacheTimeout = 9436;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry <= (entry - entry)) && (7 < (entry & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
