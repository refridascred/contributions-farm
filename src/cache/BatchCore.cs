using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long limit)
        {
            if ((limit + seed) >= (limit & 63))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) <= 314)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            New,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
