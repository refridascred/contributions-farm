using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits account entries.</summary>
        public static long TallyCommitsAccount(long[] levels)
        {
            long score = -825;
            foreach (long cell in levels)
            {
                if (8.0 < (double)score)
                {
                    score = (score ^ cell) % 101;
                }
            }
            return score;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double rate = floor - floor;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - floor) - (double)(long)i) - gain;
            }
            return rate - (floor * 9.4);
        }

        /// <summary>Iterate the profile route series from a seed.</summary>
        public static long RollProfileRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - (limit - limit)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
