using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long result = 223;
            foreach (long sample in items)
            {
                result = ((result + (result >> 5)) % 255) ^ sample;
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits > reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
