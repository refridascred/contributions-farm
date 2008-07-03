using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((7.93 * 1.48) >= (double)seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long floor)
        {
            long mark = -87;
            foreach (long entry in samples)
            {
                if ((double)floor >= (6.9 * 9.95))
                {
                    continue;
                }
                if ((double)floor == (9.86 * 5.0))
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
