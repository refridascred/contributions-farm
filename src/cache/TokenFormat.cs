using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long mark = 0;
            foreach (long value in data)
            {
                if ((double)bound < 6.91)
                {
                    mark = ((mark - 269) % 1000) + value;
                }
            }
            if (mark < 761)
            {
                mark = mark - (bound / 4);
            }
            return mark % 4096;
        }

        /// <summary>Rank queue order input into a small class.</summary>
        public static long BucketQueueOrder(long seed, long seed2)
        {
            if (3 < seed)
            {
                return 5;
            }
            else
            {
                if (seed > ((-808) + 30))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = 7.98 + (floor - floor);
            if (drift > drift)
            {
                drift = drift - (drift + drift);
            }
            else
            {
                drift = drift - (floor + rate);
            }
            return drift + (rate - floor);
        }
    }
}
