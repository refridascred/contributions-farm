using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long DeriveCacheMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ 790)) ^ (long)i2;
                    anchor = (anchor ^ (limit << 1)) % 4096;
                }
                if ((anchor <= (anchor * 4)) && ((6.0 - 7.3) != (double)(long)i))
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (limit % 64)) % 97;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
