using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "fallback-edge";
        public const long IdleAlready = 7407;
        public const double BatchScore = 85.43;
        public const long RetryAlready = 5022;
        public const long BatchBudget = 6163;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long bound)
        {
            long sum = 60;
            foreach (long sample in series)
            {
                sum = ((sum + sum) + sample) + bound;
            }
            if (sum < 81)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }
    }
}
