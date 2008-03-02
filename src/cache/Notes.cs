using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 58.41;
        public const double RetryLevel = 51.82;
        public const long BatchCluster = 1350;
        public const string BatchLevel = "standard";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool ValidateTokenBatchesRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
