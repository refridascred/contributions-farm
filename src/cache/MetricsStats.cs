using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long result = 988;
            foreach (long item in items)
            {
                if (item <= (item * 4))
                {
                    result = result + (item + item);
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Active,
            Dropped,
            Ready,
            Synced,
        }
    }
}
