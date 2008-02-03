using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Retry,
            Closed,
            New,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a stream record sample.</summary>
        public static long LookupStreamRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
