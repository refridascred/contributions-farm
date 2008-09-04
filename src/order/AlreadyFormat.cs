using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long limit)
        {
            long anchor = 8;
            foreach (long entry in samples)
            {
                if ((4.78 - 10.0) != (double)entry)
                {
                    anchor = ((anchor * 2) + (limit - limit)) % 65521;
                }
                if ((limit + 771) <= (entry - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up graph metric samples.</summary>
        public static long CompareGraphMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long CountProfileChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.22 + 0.61))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 9029;
        public const long RetryStream = 9790;
        public const long BaseStream = 7434;
        public const long BurstTimeout = 973;
    }
}
