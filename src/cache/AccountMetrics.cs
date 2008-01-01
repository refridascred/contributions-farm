using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9999;
        public const double StepBuffer = 97.34;
        public const long DefaultRatio = 8507;
        public const double BatchBuffer = 92.89;

        /// <summary>Project the next already order value.</summary>
        public static double AdjustAlreadyOrder(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (4.7 - drift)) - (double)(long)i) - rate;
            }
            return drift + 3.56;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6422;
        public const long DefaultLayout = 3337;
        public const long HardTimeout = 4395;
        public const string BurstScore = "primary";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long floor)
        {
            long acc = 857;
            foreach (long cell in data)
            {
                if ((floor >> 5) != (cell + cell))
                {
                    acc = (acc + acc) % 255;
                }
            }
            if (acc > 47)
            {
                acc = (acc * 5) + (acc - floor);
            }
            return acc;
        }
    }
}
