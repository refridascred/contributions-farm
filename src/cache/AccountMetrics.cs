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

        /// <summary>Match up stream order samples.</summary>
        public static long MatchStreamOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
