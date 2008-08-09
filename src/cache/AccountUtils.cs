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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long floor)
        {
            long score = 70;
            foreach (long cell in series)
            {
                if (!((score + floor) < (floor / 2)))
                {
                    score = (score ^ floor) % 97;
                    score = score - score;
                }
                score = score - (cell & 1);
            }
            return score % 4096;
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
