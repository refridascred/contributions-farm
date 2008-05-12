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

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
