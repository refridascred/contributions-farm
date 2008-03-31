using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8086;
        public const double LimitInterval = 92.82;
        public const string StepToken = "legacy";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Pending,
            Failed,
            Locked,
            Paused,
        }
    }
}
