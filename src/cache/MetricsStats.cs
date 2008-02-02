using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (double)73)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Draft,
            Active,
            Paused,
            Pending,
        }
    }
}
