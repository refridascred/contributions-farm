using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                if ((1.2 - 7.3) > (double)carry)
                {
                    carry = (((carry * 4) + (carry >> 5)) % 4096) + entry;
                }
            }
            if (carry > 752)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
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
