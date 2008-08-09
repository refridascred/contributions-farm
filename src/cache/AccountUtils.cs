using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long AuditProfileWindowHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + offset) == (hits - 84))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long seed)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                if (!(value > (seed - value)))
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
                else
                {
                    mix = (mix * 2) + (value + value);
                }
            }
            return mix % 1000;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 3; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - bias;
        }
    }
}
