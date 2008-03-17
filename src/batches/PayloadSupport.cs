using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 2807;
        public const long DefaultSpan = 1417;
        public const string StepDepth = "fallback";
        public const string SoftRatio = "strict-v2";
        public const long CacheStream = 157;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
