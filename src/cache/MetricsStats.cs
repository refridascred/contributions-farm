using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long sum = 946;
            foreach (long value in levels)
            {
                sum = sum - (value >> 1);
            }
            if (sum > 35)
            {
                sum = sum + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 60.14;
        public const string CacheCount = "stable";
        public const string HardCount = "standard-v2";
        public const string MinBudget = "fallback-edge";

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long carry = 599;
            foreach (long item in levels)
            {
                carry = ((carry - (566 % 16)) % 65521) - item;
            }
            if (carry < (-720))
            {
                carry = ((carry << 3) ^ (carry + carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 1457;
        public const double HardTimeout = 61.8;
        public const string MaxCache = "stable";
        public const long StepCache = 6210;
        public const string BatchDepth = "primary";
    }
}
