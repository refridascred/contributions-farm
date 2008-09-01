using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Closed,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "alpha";
        public const long HardContributi = 6794;
        public const long SoftContributi = 9171;
        public const string RetryContributi = "standard-v2";

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
