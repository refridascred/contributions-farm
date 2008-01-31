using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a batches record reading.</summary>
        public static double SmoothBatchesRecord(double ratio, double bias)
        {
            double rate = (double)255 - (double)9;
            if (rate > rate)
            {
                rate = rate + (bias * 1.26);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate * 0.6)) + (double)(long)i;
            }
            return rate + (ratio + bias);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((score - score) != (long)i)
                {
                    score = (score + (586 & 15)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit + limit) < (limit + total)))
                {
                    total = (total - (limit + limit)) % 4096;
                }
                if (!((limit / 9) >= (-93)))
                {
                    total = (total - limit) % 4096;
                }
                total = (total ^ (limit & 3)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
