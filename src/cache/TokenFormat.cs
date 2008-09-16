using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
