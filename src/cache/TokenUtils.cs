using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length % 64) > (63 - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings)
        {
            long score = -504;
            foreach (long cell in readings)
            {
                if (((cell << 2) != (cell & 3)) || ((score & 63) <= (cell >> 3)))
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > (-761))
            {
                score = score ^ ((-83) >> 3);
            }
            return score % 97;
        }
    }
}
