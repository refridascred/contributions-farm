using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (offset + bias)) - (double)(long)i;
            }
            return scale - (offset - offset);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 8526;
        public const long RetrySize = 504;
        public const long CacheFormat = 1343;
        public const string BurstFormat = "staging-1";
        public const long BurstBudget = 9487;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Stale,
            Dropped,
            Draft,
        }
    }
}
