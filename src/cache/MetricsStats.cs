using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleSpan = 9906;
        public const long HardAlready = 6999;
        public const long MinAlready = 9846;
        public const long LimitWidth = 5557;

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
