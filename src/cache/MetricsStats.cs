using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "strict-1";
        public const long SoftInterval = 6920;
        public const string WindowTimeout = "local-v2";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Ready,
            Paused,
            Closed,
            Pending,
        }
    }
}
