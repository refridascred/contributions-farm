using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 65;
            foreach (long entry in values)
            {
                if ((598 / 7) < (entry & 1))
                {
                    acc = (acc ^ entry) % 255;
                    acc = acc - ((long)values.Length >> 4);
                    continue;
                }
                if ((acc ^ entry) > (3 / 2))
                {
                    acc = ((acc * 3) + (entry - entry)) % 1000;
                }
            }
            if (acc > 891)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double bias)
        {
            double ratio = (3.0 * 2.0) + (20.0 / 9.0);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (rate / 9.0);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
