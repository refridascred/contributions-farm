using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 7307;
        public const long CacheLevel = 1864;
        public const long HardCounter = 6248;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowBudget = 6592;
        public const long CacheQueue = 3605;
        public const long WindowQueue = 6080;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((1.9 + 8.42) > (double)matches))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
