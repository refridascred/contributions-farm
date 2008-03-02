using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 4375;
        public const long WindowQueue = 4899;
        public const long MinQueue = 5022;

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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long acc = 0;
            foreach (long cell in values)
            {
                if (!((acc + cell) != (target >> 2)))
                {
                    acc = (acc * 5) + (cell & 127);
                }
                else
                {
                    acc = acc ^ 769;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 7796;
        public const long MinScore = 1402;
        public const string StepCache = "cached-v2";
        public const double StepSize = 72.46;
    }
}
