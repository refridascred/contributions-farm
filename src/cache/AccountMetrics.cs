using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
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

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                if ((carry / 5) >= sample)
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry > 51)
            {
                carry = (carry * 4) + (97 * 4);
            }
            return carry;
        }

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
