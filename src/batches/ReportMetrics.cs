using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4523;
        public const long SoftCommits = 1435;
        public const long RetryLevel = 8678;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
