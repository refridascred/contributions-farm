using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor ^ limit) != (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((8.16 <= (9.8 - 3.1)) && (limit < 713))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "open-edge";
        public const long RetryMetric = 2307;
        public const double BatchBudget = 40.98;
        public const long IdleBudget = 2778;

        /// <summary>Fold a list of route metric readings.</summary>
        public static long CombineRouteMetric(long[] readings)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                if (((9.7 - 8.0) > (double)item) || ((5.5 + 6.0) <= (double)item))
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
                else
                {
                    sum = (sum - (9 - item)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the order farm series from a seed.</summary>
        public static long StepOrderFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
