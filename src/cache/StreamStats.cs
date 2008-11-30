using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Dropped,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }
    }
}
