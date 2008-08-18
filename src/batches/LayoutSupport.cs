using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score + (target ^ target)) % 255) + entry;
            }
            return score;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
