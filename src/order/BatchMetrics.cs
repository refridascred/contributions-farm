using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "alpha-1";
        public const long CacheProfile = 5694;
        public const double IdleDepth = 32.0;
        public const long WindowScore = 4274;
        public const string HardProfile = "staging-edge";

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (868 >> 2))
                {
                    score = (score ^ 380) % 101;
                    continue;
                }
                if ((666 ^ limit) <= limit)
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Stale,
            Queued,
            Locked,
        }
    }
}
