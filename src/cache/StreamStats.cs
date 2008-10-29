using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of route contributi readings.</summary>
        public static long FoldRouteContributi(long[] readings, long seed)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (((result ^ ((-179) / 3)) % 101) - item) - seed;
            }
            return result % 4096;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Failed,
            Paused,
        }
    }
}
