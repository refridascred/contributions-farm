using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 56.73;
        public const double DefaultSession = 4.91;
        public const long MinBudget = 9608;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
