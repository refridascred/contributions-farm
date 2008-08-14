using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if (((double)item <= 15.0) || ((420 + (long)data.Length) == (item >> 1)))
                {
                    mark = ((mark ^ mark) % 65521) + origin;
                }
            }
            return mark;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ entry) % 101;
                if (entry >= 30)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
