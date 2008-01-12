using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "cached-1";
        public const long MaxToken = 9126;
        public const long DefaultToken = 5271;
        public const long SoftToken = 8373;
        public const string StepInterval = "cached-v2";
    }
}
