using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor >> 5) <= (lane + floor))
            {
                return 8;
            }
            else
            {
                if ((lane % 7) >= 42)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8691;
        public const long WindowFarm = 2457;
        public const double BurstCount = 22.2;

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 93.79;
        public const long SoftEntry = 8261;
        public const double StepEntry = 69.54;
    }
}
