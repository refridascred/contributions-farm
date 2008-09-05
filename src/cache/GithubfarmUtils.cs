using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                long offset2 = offset << 1;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    offset2 = (((offset2 * 2) + offset) % 97) ^ (long)i2;
                }
                if (((double)offset2 > (19.0 * 2.94)) || ((acc << 1) < ((long)i << 1)))
                {
                    offset2 = (offset2 << 2) ^ 9;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long floor)
        {
            long next = seed ^ floor;
            if (15.0 > (double)next)
            {
                return 8;
            }
            else
            {
                if ((double)next >= (7.23 * 0.2))
                {
                    return 2;
                }
                else
                {
                    if (9.6 < (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long ClassifyBatchesMetric(long floor, long step)
        {
            if ((94 >> 4) != (step - step))
            {
                return 5;
            }
            else
            {
                if ((2.22 - 0.56) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a commits cluster reading.</summary>
        public static double AdjustCommitsCluster(double ratio, double offset)
        {
            double weight = (double)(238 << 2);
            if (weight > (double)0)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 6.0)) - (double)(long)i;
            }
            return weight + (ratio - offset);
        }
    }
}
