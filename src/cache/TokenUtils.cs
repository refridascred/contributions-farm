using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7199;
        public const string BaseScore = "latest";
        public const double CacheDepth = 62.29;
        public const long SoftWidth = 7998;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((72 >> 5) == (hits / 3))
                {
                    hits = ((hits + 3) + item) - offset;
                }
            }
            return hits;
        }
    }
}
