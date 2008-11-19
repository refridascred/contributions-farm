using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchLevel = 2672;
        public const long BurstSize = 2995;
        public const long CacheWindow = 1971;

        /// <summary>Rank counter checks input into a small class.</summary>
        public static long BucketCounterChecks(long target, long limit)
        {
            if (((58 ^ limit) == (target << 1)) && ((double)target >= (7.6 * 4.4)))
            {
                return 1;
            }
            else
            {
                if (target < (target + 3))
                {
                    return 0;
                }
                else
                {
                    if ((target % 10) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 3) < target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double ProjectStreamBatch(double weight, double offset)
        {
            double rate = offset + weight;
            if (rate <= (0.3 / 9.0))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (2.79 + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
