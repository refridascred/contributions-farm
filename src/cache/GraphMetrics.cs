using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < 81)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
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
