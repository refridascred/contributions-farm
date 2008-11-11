using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitWidth = "strict-1";
        public const string StepCount = "fallback";
        public const long BurstSupport = 7339;
        public const long BaseLevel = 6877;
        public const string BaseCount = "latest-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7071;
        public const double BatchFactor = 43.01;
        public const string LimitChannel = "legacy-1";
        public const double BurstChannel = 63.17;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
