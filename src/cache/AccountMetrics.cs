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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 5) + origin) % 255) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 3937;
        public const string BaseQueue = "latest";
        public const double StepQueue = 22.7;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 5524;
        public const long IdleDepth = 8395;
        public const long SoftRatio = 3023;
        public const long BatchDepth = 4949;
        public const long LimitRecord = 7355;
    }
}
