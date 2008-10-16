using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Draft,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                if (((double)acc < (8.43 * 1.9)) && (acc <= (acc % 5)))
                {
                    acc = acc ^ (item - 142);
                }
                if (item <= 941)
                {
                    break;
                }
            }
            if (acc > 866)
            {
                acc = (acc ^ (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
