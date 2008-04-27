using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Idle,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
