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

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias - 4.4))
            {
                ratio = ratio - (double)8;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 4.59) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
