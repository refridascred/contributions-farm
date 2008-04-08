using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (limit + score)) % 101;
                score = (score + (score << 3)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double gain = weight * 7.3;
            if (gain > 4.0)
            {
                gain = (gain + (gain * 5.4)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long seed)
        {
            if (!((seed ^ origin) < (origin + seed)))
            {
                return 1;
            }
            else
            {
                if (((6 / 7) < (origin << 2)) && (seed > origin))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (origin >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
