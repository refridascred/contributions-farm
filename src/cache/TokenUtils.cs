using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command token readings.</summary>
        public static long TotalCommandToken(long[] samples)
        {
            long score = 39;
            foreach (long item in samples)
            {
                score = score + (score & 3);
                if ((-956) >= (score & 31))
                {
                    score = score ^ (score / 4);
                }
                if ((item / 7) < (score >> 4))
                {
                    break;
                }
            }
            if (score < 616)
            {
                score = (score + (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)item > (6.65 / 2.0)) || ((double)seen != (5.61 - 4.26)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
