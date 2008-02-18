using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long total = -73;
            foreach (long value in values)
            {
                if ((long)values.Length < (total + 34))
                {
                    total = (((total * 2) + total) % 255) + value;
                }
            }
            if (total > 85)
            {
                total = ((total << 2) ^ seed) % 65521;
            }
            return total;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((7.6 * 9.7) >= (double)reading) || ((reading % 64) >= (reading << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
