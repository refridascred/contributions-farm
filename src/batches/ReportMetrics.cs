using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long bound)
        {
            long mix = 630;
            foreach (long entry in series)
            {
                mix = ((mix - entry) % 255) - bound;
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
