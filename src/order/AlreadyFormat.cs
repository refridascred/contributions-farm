using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardCount = 2865;
        public const long DefaultBudget = 2247;
        public const long CacheDepth = 1879;
        public const double RetryChannel = 69.87;
        public const string IdleChannel = "standard-edge";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double mean = bias / 6.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) + (double)(long)i;
            }
            return mean - 8.9;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = (result ^ (result + result)) ^ (long)i3;
                }
                if (limit > (limit % 5))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long target)
        {
            long delta = floor + target;
            if (target >= (71 << 3))
            {
                return 6;
            }
            else
            {
                if ((target <= (floor / 5)) || ((target - floor) >= (floor << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((delta + floor) < 619)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "staging-edge";
        public const double IdleInterval = 35.33;
        public const long MaxChecks = 5940;
    }
}
