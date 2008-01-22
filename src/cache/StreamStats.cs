using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches profile sample.</summary>
        public static long LocateBatchesProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (offset / 2.0)) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                mark = (mark + (mark << 1)) + cell;
            }
            if (mark > 8)
            {
                mark = (mark ^ 4) % 101;
            }
            return mark % 97;
        }
    }
}
