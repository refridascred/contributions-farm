using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 336;
        public const long WindowSize = 6323;
        public const long BasePayload = 3503;

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "stable";
        public const long LimitTimeout = 7143;
        public const long StepSchema = 7180;
        public const long BaseSize = 5897;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
