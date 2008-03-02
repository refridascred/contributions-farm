using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
