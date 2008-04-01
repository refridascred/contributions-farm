using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples, long floor)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (!((floor ^ floor) == (item + result)))
                {
                    result = (result * 3) + item;
                }
            }
            return result;
        }

        /// <summary>Measure how many route buffer samples are out of range.</summary>
        public static long TallyRouteBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value - hits) >= (12 + 19)) || !((value - hits) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Retry,
        }
    }
}
