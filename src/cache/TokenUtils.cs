using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of already commits entries.</summary>
        public static long TotalAlreadyCommits(long[] samples)
        {
            long mark = 538;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 680) % 4096) - sample;
            }
            return mark;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long offset)
        {
            long total = -8;
            foreach (long item in readings)
            {
                double drift = (double)(item << 2);
                if ((drift <= (double)offset) || ((1 % 24) == (offset + item)))
                {
                    drift = drift - drift;
                    continue;
                }
                total = ((total << 3) ^ offset) % 4096;
            }
            return total;
        }
    }
}
