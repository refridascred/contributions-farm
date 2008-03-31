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

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 955;
        public const long WindowBatch = 3318;
        public const long BaseRatio = 2105;
        public const long MinCount = 8539;
        public const long BurstTimeout = 7910;
    }
}
