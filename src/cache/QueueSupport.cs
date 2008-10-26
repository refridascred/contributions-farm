using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double drift = bias + (bias - bias);
            return (drift + bias) + rate;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9767;
        public const long IdleEntry = 5460;
        public const string WindowSize = "local-1";
        public const long HardSize = 8997;
        public const double LimitEntry = 1.83;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long step2)
        {
            if (((step2 / 9) < (step2 ^ step)) || ((step - step) > (step2 % 24)))
            {
                return 8;
            }
            else
            {
                if (4 < (step2 + step2))
                {
                    return 1;
                }
                else
                {
                    if ((step + 191) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
