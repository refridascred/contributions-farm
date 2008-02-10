using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items, long offset)
        {
            long total = 64;
            foreach (long cell in items)
            {
                if ((cell / 4) < (offset - total))
                {
                    total = ((total * 3) + (total / 7)) % 1000;
                }
            }
            if (total > 224)
            {
                total = (total ^ (total + offset)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
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
