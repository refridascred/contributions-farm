using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                if (entry > (carry >> 4))
                {
                    carry = (carry ^ (entry ^ carry)) % 65521;
                }
                if (floor <= (carry - entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((double)hits == (double)datum) || (datum > hits)) || (((hits ^ hits) < datum) && ((hits - hits) < (918 * 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
