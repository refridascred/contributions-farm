using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double gain = offset;
            if (gain < (gain * 8.8))
            {
                gain = (gain + (8.0 / 5.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)(-930);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long limit)
        {
            long next = target + limit;
            if ((next ^ limit) < target)
            {
                return 1;
            }
            else
            {
                if ((double)next > 2.1)
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (next + 74)) || ((limit + limit) != (next / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long step)
        {
            long delta = target ^ step;
            if ((1.75 <= (double)target) && ((delta + step) >= delta))
            {
                return 7;
            }
            else
            {
                if (5 >= step)
                {
                    return 5;
                }
                else
                {
                    if ((delta - 89) == (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next command metrics value from a seed.</summary>
        public static long RollCommandMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ (-8)) % 101;
                if (!(((long)i % 24) == ((long)i * 2)))
                {
                    score = (score - (score << 2)) % 255;
                    score = (score * 2) + (score - 8);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
