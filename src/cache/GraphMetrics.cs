using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 890;
        public const long BaseSize = 4090;
        public const long MaxScore = 5195;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Retry,
            Failed,
            New,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
