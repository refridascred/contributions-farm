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

        /// <summary>Measure how many schema stats samples are out of range.</summary>
        public static long TallySchemaStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value > (1.3 * 7.41))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
