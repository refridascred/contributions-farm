using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (double)957)
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

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 30.48;
        public const double BaseSize = 70.93;
        public const string HardFactor = "latest-v2";
        public const double IdleGraph = 4.02;
        public const string RetryGraph = "strict-v2";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Draft,
            Closed,
        }
    }
}
