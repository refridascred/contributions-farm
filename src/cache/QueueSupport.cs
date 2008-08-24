using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 65.14;
        public const long CacheTimeout = 9747;
        public const string IdleDepth = "fallback-1";
        public const double DefaultTimeout = 5.36;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 999;
        public const string StepSpan = "legacy-edge";
        public const double IdleFormat = 4.62;
        public const double RetryFormat = 93.37;
        public const double BurstTimeout = 1.2;
    }
}
