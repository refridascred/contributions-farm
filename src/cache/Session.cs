using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long sum = 78;
            foreach (long entry in values)
            {
                if ((entry - (-25)) != (entry & 3))
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-1";
        public const long DefaultCounter = 8944;
        public const long IdleCounter = 9540;
        public const string RetryCounter = "latest-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 9483;
        public const long IdleReport = 3199;
        public const double HardReport = 37.38;
        public const long MaxDepth = 7296;
        public const string HardInterval = "standard-v2";
    }
}
