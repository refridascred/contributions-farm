using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc - (limit / 4)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long offset)
        {
            long lane = target + offset;
            if (lane < (lane >> 5))
            {
                return 6;
            }
            else
            {
                if ((lane - lane) < target)
                {
                    return 5;
                }
                else
                {
                    if ((target / 3) > (lane + 228))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
