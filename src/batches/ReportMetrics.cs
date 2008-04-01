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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ offset;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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
