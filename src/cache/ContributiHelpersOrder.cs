using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a already batches sample.</summary>
        public static long SeekAlreadyBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 56.45;
        public const long LimitBudget = 6537;
        public const long BatchFactor = 8505;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Retry,
            New,
        }
    }
}
