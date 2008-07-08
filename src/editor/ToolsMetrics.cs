using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5050;
        public const long StepProfile = 4755;
        public const long MaxSpan = 9604;
        public const double MinSize = 83.2;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleLevel = 6902;
        public const string BatchFormat = "standard";
        public const long DefaultFormat = 8194;
        public const long DefaultWidth = 5942;
        public const double LimitFormat = 18.67;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}
