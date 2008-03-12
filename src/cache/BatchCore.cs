using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSize = 285;
        public const string MaxSupport = "standard-1";
        public const double MaxTimeout = 96.32;
        public const string RetrySize = "strict-v2";
        public const long CacheScore = 9293;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry + (long)i2) % 97;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long WeighEntryOrder(long[] readings)
        {
            long acc = 9;
            foreach (long sample in readings)
            {
                if (!(2 < acc))
                {
                    acc = (acc * 4) + acc;
                }
                if (!((acc / 7) >= (864 + sample)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
