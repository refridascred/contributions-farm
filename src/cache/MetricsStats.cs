using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ 4) < (entry ^ matches)) || ((entry + entry) != (entry * 4)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-1";
        public const long BurstRoute = 1246;
        public const string MaxSpan = "strict";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }
    }
}
