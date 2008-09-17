using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
