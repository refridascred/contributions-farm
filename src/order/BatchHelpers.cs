using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster batches input into a small class.</summary>
        public static long BucketClusterBatches(long origin, long bound)
        {
            long edge = origin + bound;
            if ((bound + bound) != (origin + (-74)))
            {
                return 5;
            }
            else
            {
                if (origin > (origin - edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.17) + (double)(long)i;
            }
            return drift + (bias * 19.0);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (score & 127)) % 255;
                if (((double)(long)i == (5.67 - 7.03)) && ((17.0 - 5.3) < (double)(long)i))
                {
                    score = (score << 3) ^ ((long)i - score);
                    score = (score - (origin - score)) % 255;
                }
                score = score + (score + score);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
