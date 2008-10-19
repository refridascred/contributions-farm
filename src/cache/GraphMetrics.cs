using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] data, long target)
        {
            long total = 98;
            foreach (long reading in data)
            {
                total = (total ^ (target / 8)) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Ready,
            New,
            Done,
        }
    }
}
