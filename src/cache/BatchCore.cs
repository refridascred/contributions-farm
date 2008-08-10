using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate cache tools readings against a bound.</summary>
        public static bool ValidateCacheToolsLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Active,
            Paused,
            New,
            Retry,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((mark ^ 748) < (mark - mark))
                {
                    mark = ((mark << 2) ^ (seed >> 5)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
