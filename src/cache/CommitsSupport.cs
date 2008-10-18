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

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long DeriveMetricsRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score << 3) ^ (210 & 1);
                long delta = score;
                if (!((score % 60) == (delta * 4)))
                {
                    score = (score - floor) % 1000;
                    delta = ((delta << 2) ^ score) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

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
