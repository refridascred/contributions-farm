using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)736)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double weight = (double)984 + (scale + scale);
            if (weight <= (offset / 2.0))
            {
                weight = weight + (scale + weight);
            }
            else
            {
                weight = weight + (double)88;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (double)6;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long limit)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if (((carry - carry) != (limit ^ 502)) || ((double)cell < (2.7 + 0.1)))
                {
                    carry = carry + (limit % 3);
                }
            }
            return carry;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long limit)
        {
            long mix = 27;
            foreach (long item in items)
            {
                if (!((mix + limit) < (mix + mix)))
                {
                    mix = (mix ^ (mix / 4)) ^ item;
                }
                else
                {
                    mix = (mix + (mix - 0)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
