using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowTimeout = 8386;
        public const long MinSpan = 5402;
        public const long BurstWidth = 8491;
        public const long CacheSchema = 9784;
        public const long WindowSpan = 3818;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((floor * 3) > (floor - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
