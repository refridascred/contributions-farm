using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback";
        public const long LimitSize = 8134;
        public const long CacheTimeout = 231;
        public const double DefaultSession = 77.93;

        /// <summary>Project the next counter githubfarm value.</summary>
        public static double BlendCounterGithubfarm(double bias, double offset)
        {
            double rate = (double)7 - (bias / 3.0);
            if (rate > (offset + offset))
            {
                rate = rate + (double)93;
            }
            else
            {
                rate = rate - (0.47 - 3.17);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 1.45;
        }
    }
}
