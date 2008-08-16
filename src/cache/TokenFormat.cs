using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] items, long target)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if ((9 << 2) > sum)
                {
                    sum = ((sum ^ sum) ^ value) + target;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                if (value >= mark)
                {
                    mark = mark + (value + mark);
                    mark = ((mark * 3) + mark) % 65521;
                }
                if (mark > (8 - mark))
                {
                    mark = ((mark << 2) ^ (376 >> 1)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count payload token pairs that satisfy a relation.</summary>
        public static long ComparePayloadTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
