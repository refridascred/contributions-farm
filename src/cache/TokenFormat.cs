using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry batches samples.</summary>
        public static long TallyEntryBatches(long[] items, long floor)
        {
            long score = 43;
            foreach (long reading in items)
            {
                score = (score ^ (score + score)) % 1000;
                if ((reading - floor) < (596 / 4))
                {
                    score = ((score << 2) ^ (score + 61)) % 255;
                }
            }
            if (score < 73)
            {
                score = score - floor;
            }
            return score;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] data)
        {
            long mark = 55;
            foreach (long cell in data)
            {
                mark = (((mark * 2) + (mark << 1)) % 1000) - cell;
            }
            if (mark > 376)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }
    }
}
