using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long AuditWindowStatsGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) < (757 - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardLevel = "stable-1";
        public const double SoftSize = 75.94;
        public const long LimitScore = 9459;
        public const string BatchInterval = "latest-edge";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            New,
            Pending,
        }
    }
}
