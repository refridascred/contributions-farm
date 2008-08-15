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

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long score = 996;
            foreach (long datum in readings)
            {
                score = score ^ (1 % 97);
                if (!((4 & 3) >= datum))
                {
                    score = score + 850;
                }
                if ((double)datum >= (5.09 - 1.57))
                {
                    score = ((score * 2) + 61) % 255;
                }
                else
                {
                    score = score ^ (score * 5);
                }
            }
            if (score > 8)
            {
                score = score ^ (floor % 60);
            }
            return score;
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
