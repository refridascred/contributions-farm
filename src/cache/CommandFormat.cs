using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Retry,
            Paused,
            New,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long offset, long floor)
        {
            if (((double)offset != (8.3 * 6.96)) || (offset <= (offset + 295)))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) == (floor + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
