using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window batch entries.</summary>
        public static long TallyWindowBatch(long[] samples, long seed)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((seed & 31) == (item & 7))
                {
                    state = (state << 3) ^ (7 + 394);
                }
            }
            return state % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double rate = (bias + 8.0) + (bias + 7.6);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) - bias2;
            }
            return rate + rate;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if ((double)score <= (4.9 + 7.6))
                {
                    score = (((score << 2) ^ (score * 3)) % 65521) + limit;
                }
                if ((double)entry >= (double)14)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = (score << 2) ^ (score / 8);
            }
            return score % 1000;
        }
    }
}
