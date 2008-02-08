using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate commits buffer samples.</summary>
        public static long FoldCommitsBuffer(long[] values)
        {
            long mark = 17;
            foreach (long value in values)
            {
                if ((15.0 + 6.0) == (double)mark)
                {
                    mark = (mark + (value + mark)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (value & 3)) % 101;
                    mark = (mark ^ (mark - mark)) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark - (3 >> 2)) ^ (long)i;
                }
                if (value < (9 % 16))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            if (mark > 43)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples)
        {
            long mark = 838;
            foreach (long sample in samples)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 65521) ^ sample;
            }
            if (mark < 816)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }
    }
}
