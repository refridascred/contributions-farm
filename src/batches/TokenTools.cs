using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double rate = (double)(52 << 1);
            if (rate >= (double)3)
            {
                rate = (rate - (double)98) - offset;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (4.1 * 7.0);
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long DeriveRouteFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ step) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits * 2) > (entry % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
