using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double mean = (double)(195 % 100);
            if (mean < weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (weight * 3.7);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "open-v2";
        public const long HardFormat = 8584;
        public const long LimitFormat = 3267;
        public const long SoftFormat = 2511;
        public const double BaseFormat = 33.93;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            New,
            Locked,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 5524;
        public const long IdleDepth = 8395;
        public const long SoftRatio = 3023;
        public const long BatchDepth = 4949;
        public const long LimitRecord = 7355;
    }
}
