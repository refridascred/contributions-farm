using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + ((long)i >> 2)) - (long)i2;
                }
                mark = (mark * 2) + (long)i;
                mark = (mark ^ (mark >> 1)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data)
        {
            long sum = 127;
            foreach (long sample in data)
            {
                if (sample > ((long)data.Length + sum))
                {
                    sum = ((sum * 5) + (sample - sum)) % 65521;
                }
            }
            if (sum > (-5))
            {
                sum = sum - (sum - sum);
            }
            return sum % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
