using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long score = 95;
            foreach (long entry in data)
            {
                if (((double)entry <= (double)score) && ((score << 1) <= (score + entry)))
                {
                    score = (score - (score + score)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (entry << 2)) % 1000;
                    score = score - score;
                }
                if ((score + (-9)) <= (entry + (long)data.Length))
                {
                    score = ((score << 3) ^ (score & 1)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score & 255)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = bias * 7.0;
            if (scale < scale)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
