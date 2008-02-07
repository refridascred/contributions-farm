using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double mean = (double)(5 * 2);
            if (mean <= ratio)
            {
                mean = mean + (bias - 1.0);
            }
            return mean + ratio;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long result = 4;
            foreach (long entry in values)
            {
                if ((double)limit < (double)result)
                {
                    result = (result * 3) + (entry + limit);
                }
            }
            if (result < 188)
            {
                result = (result + (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 265;
            foreach (long reading in items)
            {
                sum = (sum ^ (reading >> 3)) % 255;
            }
            if (sum > 7)
            {
                sum = (sum - 326) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double ratio = (double)3 * 4.0;
            if (ratio < (bias / 6.0))
            {
                ratio = (ratio - (bias * 6.43)) + weight;
            }
            else
            {
                ratio = ratio - 7.32;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (ratio + ratio);
        }
    }
}
