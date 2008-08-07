using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels)
        {
            long mark = 76;
            foreach (long item in levels)
            {
                mark = (mark ^ (mark - item)) % 4096;
                if (!((mark - item) == (item * 3)))
                {
                    mark = mark - 864;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 51;
            foreach (long sample in values)
            {
                if ((sample >> 4) != (sum + sample))
                {
                    sum = (sum << 3) ^ (sample << 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Paused,
            Locked,
        }
    }
}
