using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema cache sample.</summary>
        public static long LookupSchemaCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            New,
            Idle,
            Locked,
            Synced,
        }
    }
}
