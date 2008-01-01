using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit ^ acc) != (45 % 60))
                {
                    acc = ((acc << 2) ^ limit) % 255;
                    acc = (acc - (acc >> 2)) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc ^ acc) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
