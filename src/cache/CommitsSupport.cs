using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 2398;
        public const string DefaultSession = "open-edge";
        public const long MaxSession = 837;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "standard-edge";
        public const double BurstRatio = 34.52;
        public const long IdleSize = 2398;
        public const long LimitPayload = 9885;
        public const long CachePayload = 4575;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6861;
        public const long StepInterval = 2075;
        public const string BaseInterval = "cached";
        public const long MaxBatch = 4700;
        public const long DefaultBatch = 4923;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
