using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
