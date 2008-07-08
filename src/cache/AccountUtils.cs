using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series, long step)
        {
            long sum = 203;
            foreach (long value in series)
            {
                if ((double)step < 2.19)
                {
                    sum = ((sum * 3) + (step + value)) % 1000;
                }
                else
                {
                    sum = sum - (step + sum);
                }
            }
            if (sum < 734)
            {
                sum = (sum * 3) + step;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3258;
        public const string RetryAlready = "cached-v2";
        public const long StepWidth = 5358;
        public const long LimitAlready = 9699;
        public const long HardWidth = 5687;
    }
}
