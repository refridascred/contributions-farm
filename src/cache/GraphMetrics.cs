using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long target)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (target * 4)) % 1000) - reading;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
