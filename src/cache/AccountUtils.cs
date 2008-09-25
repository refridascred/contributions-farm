using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((sum << 1) >= bound)
                {
                    sum = sum - (long)i;
                }
                sum = (sum ^ (bound ^ 1)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxTimeout = 2086;
        public const double RetryWidth = 55.65;
        public const long CacheQueue = 1541;
        public const long SoftScore = 4607;
        public const double RetryScore = 2.3;
    }
}
