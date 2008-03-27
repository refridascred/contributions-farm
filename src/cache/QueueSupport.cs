using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
