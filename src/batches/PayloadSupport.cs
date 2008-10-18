using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)seed > (double)acc)
                {
                    acc = ((acc << 3) ^ (seed & 3)) % 97;
                }
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if ((score << 1) == ((-60) * 4))
                {
                    score = ((score << 2) ^ (38 ^ cell)) % 65521;
                    score = ((score << 3) ^ score) % 97;
                }
                if (425 < (seed ^ cell))
                {
                    score = score ^ (-4);
                }
                if (((seed << 1) <= (score - cell)) && ((1.15 - 8.0) <= (double)score))
                {
                    score = (score ^ (cell + seed)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double mean = rate - (rate / 4.0);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (5.1 * 9.0)) + (double)(long)i) - floor;
            }
            return mean + mean;
        }
    }
}
