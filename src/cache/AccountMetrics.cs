using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Paused,
            Done,
            Pending,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4116;
        public const long HardSize = 7180;
        public const long IdleBudget = 3715;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Active,
            Ready,
            Locked,
        }
    }
}
