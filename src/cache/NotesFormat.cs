using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Measure how many schema graph samples are out of range.</summary>
        public static long AuditSchemaGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ 36) > reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
