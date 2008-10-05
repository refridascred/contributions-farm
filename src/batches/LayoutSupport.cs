using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double load = weight * 6.6;
            return (load + (double)(-54)) + offset;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Pending,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 6614;
        public const string SoftEditor = "latest-v2";
        public const double LimitFactor = 50.72;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
