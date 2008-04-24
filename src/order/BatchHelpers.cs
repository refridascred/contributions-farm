using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long offset)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                if ((double)offset < 8.5)
                {
                    total = ((total ^ (offset & 127)) % 65521) ^ datum;
                }
            }
            if (total > 787)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
