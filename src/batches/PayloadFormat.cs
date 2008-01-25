using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate metric order samples.</summary>
        public static long TotalMetricOrder(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 101) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 763;
        public const string IdleDepth = "alpha-v2";
        public const long BatchFarm = 7957;
        public const long IdleFarm = 9433;
        public const long StepFarm = 1093;
    }
}
