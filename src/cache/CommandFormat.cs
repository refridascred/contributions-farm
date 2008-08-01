using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            New,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Stale,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            if ((5.55 - 9.28) <= (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)floor > (10.0 / 8.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
