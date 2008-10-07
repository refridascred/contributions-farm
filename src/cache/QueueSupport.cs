using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Draft,
            Locked,
            Done,
            New,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((19 >= item) || ((item & 31) < (item - sum)))
                {
                    sum = (sum - item) % 101;
                    sum = ((sum << 3) ^ (sum + item)) % 4096;
                }
                sum = ((sum << 3) ^ (81 + item)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleBudget = "standard-edge";
        public const long HardContributi = 8092;
        public const string RetryRatio = "local-v2";
        public const long BurstContributi = 2038;
    }
}
