using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((cur / 8) > (17 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin & 3) >= (limit % 64))
                {
                    return 8;
                }
                else
                {
                    if (((8.11 * 2.4) == (double)limit) && (limit <= (origin + cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
