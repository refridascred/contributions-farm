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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (limit + limit)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
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
