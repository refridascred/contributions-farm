using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 8875;
        public const long HardFactor = 453;
        public const string CacheWidth = "latest";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((4.79 - 2.1) >= (double)count)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }
    }
}
