using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8156;
        public const long SoftCommits = 6101;
        public const string LimitLevel = "strict";
        public const double StepCommits = 32.77;
        public const string MinTimeout = "primary-1";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 46.21;
        public const long MinSize = 7503;
        public const long LimitSize = 9006;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 18.91;
        public const long CacheDepth = 1072;
        public const string MinCommand = "open-edge";
        public const double SoftScore = 38.8;
        public const double RetryInterval = 19.88;
    }
}
