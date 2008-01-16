using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheCount = 4117;
        public const double BurstDepth = 80.66;
        public const long BatchCount = 6204;

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias - bias))
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias - rate)) + (double)(long)i;
            }
            return bias2 + rate;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultInterval = 2431;
        public const long DefaultBudget = 4892;
        public const long BatchInterval = 7931;
        public const long HardSpan = 4379;
        public const long SoftLevel = 1009;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
