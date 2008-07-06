using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor * 2) + floor;
                if (((double)anchor >= (double)floor) && ((1.09 - 5.0) == (double)anchor))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if ((reading + reading) < (-375))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total - (total >> 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Dropped,
            Paused,
            Active,
        }
    }
}
