using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 519;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc + ((long)i >> 4)) % 255) + cell;
                }
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
