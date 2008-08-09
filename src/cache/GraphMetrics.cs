using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stream already readings.</summary>
        public static long FoldStreamAlready(long[] data)
        {
            long score = 3;
            foreach (long value in data)
            {
                score = (score * 5) + (value % 8);
                if ((1 + score) != (score + value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "open";
        public const string MaxCount = "fallback-edge";
        public const long BaseContext = 9935;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 61.22;
        public const double WindowSchema = 69.39;
        public const long CacheSchema = 9847;
        public const double SoftSchema = 16.36;
        public const long RetrySchema = 1118;
    }
}
