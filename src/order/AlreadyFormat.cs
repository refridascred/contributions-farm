using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Failed,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
