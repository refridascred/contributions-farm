using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache checks samples.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long sum = -49;
            foreach (long reading in values)
            {
                long diff = reading;
                if ((sum + sum) >= (diff + diff))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
                else
                {
                    sum = (sum - (sum / 4)) % 97;
                }
                if ((sum * 3) > (sum / 6))
                {
                    sum = (sum * 4) + (5 + sum);
                }
                else
                {
                    sum = (sum + (sum % 5)) % 97;
                }
            }
            if (sum > 21)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultScore = "primary-edge";
        public const double HardRecord = 92.41;
        public const long BurstRecord = 8690;
        public const string DefaultRecord = "standard";
        public const long RetryRecord = 1449;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
