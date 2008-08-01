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

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Pending,
            Active,
            Done,
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
