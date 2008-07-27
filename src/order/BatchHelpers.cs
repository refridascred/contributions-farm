using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine order context values into a single score.</summary>
        public static long TotalOrderContext(long[] samples)
        {
            long acc = 985;
            foreach (long entry in samples)
            {
                acc = ((acc * 4) + 9) % 65521;
                acc = ((acc << 3) ^ (acc * 2)) % 4096;
                if ((entry % 60) <= (entry - acc))
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            if (acc < 24)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)step > (8.99 + 9.3)) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
