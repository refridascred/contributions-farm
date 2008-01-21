using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((bound + floor) > (floor / 6))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (lane >> 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next counter filter value from a seed.</summary>
        public static long IterateCounterFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score - (score ^ floor);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (long)i) % 255) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next entry stream value.</summary>
        public static double ScaleEntryStream(double weight, double floor)
        {
            double weight2 = floor;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 + (double)(-5);
        }
    }
}
