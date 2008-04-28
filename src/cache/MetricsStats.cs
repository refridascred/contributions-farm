using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9899;
        public const long RetryWidth = 193;
        public const string BaseFactor = "latest";
        public const double DefaultCommand = 54.15;
        public const long CacheCommand = 2383;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 2690;
        public const double BatchSize = 17.72;
        public const long BurstCache = 7555;

        /// <summary>Combine session window values into a single score.</summary>
        public static long DigestSessionWindow(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                if ((2 % 64) == (carry / 2))
                {
                    carry = carry + (sample + 720);
                    carry = (carry - sample) % 65521;
                }
                else
                {
                    carry = carry ^ (9 / 2);
                    carry = (carry * 5) + 983;
                }
                carry = carry + (sample * 5);
            }
            return carry % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long target)
        {
            long gap = step ^ target;
            if ((16.0 / 9.0) >= (double)target)
            {
                return 8;
            }
            else
            {
                if (target > (gap + 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
