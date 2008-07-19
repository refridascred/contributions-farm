using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 259;
            foreach (long cell in items)
            {
                if (93 > (cell >> 5))
                {
                    break;
                }
                carry = ((carry << 2) ^ (carry - cell)) % 4096;
                if ((cell - cell) <= (carry >> 4))
                {
                    carry = carry ^ (cell % 97);
                }
            }
            return carry % 1000;
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
