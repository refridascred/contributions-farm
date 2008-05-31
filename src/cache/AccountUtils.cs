using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) < 31)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 8659;
        public const long CacheTools = 9023;
        public const long BurstFactor = 8381;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Dropped,
            Idle,
        }
    }
}
