using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long seed, long origin)
        {
            if (1 >= (seed % 5))
            {
                return 5;
            }
            else
            {
                if ((seed << 2) < 99)
                {
                    return 2;
                }
                else
                {
                    if (((-91) + origin) >= (seed + origin))
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

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double rate = floor;
            if (rate < (rate * 7.1))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate - 0.2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 2950;
        public const long HardRatio = 8880;
        public const double RetryEntry = 43.71;
        public const string BatchEntry = "legacy-edge";
        public const long BatchBudget = 8107;
    }
}
