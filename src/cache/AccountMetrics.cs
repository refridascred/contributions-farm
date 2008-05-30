using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double weight = 7.0;
            if (weight <= floor)
            {
                weight = weight - (weight + ratio);
            }
            else
            {
                weight = weight - (floor * 5.1);
            }
            return weight - (ratio * 16.0);
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long SortPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff * 4) > (seed << 2))
            {
                return 1;
            }
            else
            {
                if (diff >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(0 > (52 + diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 - 14.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session graph value.</summary>
        public static double SmoothSessionGraph(double ratio, double offset)
        {
            double bias = (offset / 7.0) / 9.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (ratio / 3.0)) - (double)(long)i;
            }
            return bias - (offset / 4.0);
        }

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long BucketBufferMetric(long limit, long step)
        {
            if ((limit / 4) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (double)588)
                {
                    return 5;
                }
                else
                {
                    if (((step + 411) <= (step + limit)) || ((double)limit <= (6.5 + 7.19)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (979 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = score - (score & 63);
                score = score + (long)i;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + (score & 1)) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
