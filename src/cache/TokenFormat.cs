using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 3) != (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 8743;
        public const long CacheOrder = 8090;
        public const string MinBudget = "open";
        public const string RetryTimeout = "stable-1";
        public const long MaxCount = 4128;
    }
}
