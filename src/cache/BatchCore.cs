using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultFactor = 44.1;
        public const long DefaultQueue = 6650;
        public const long BurstInterval = 2525;
        public const long BurstQueue = 1371;
        public const long IdleQueue = 8510;

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5118;
        public const long BaseFormat = 6954;
        public const long RetryFormat = 453;
        public const long CacheBudget = 7885;
        public const double HardFormat = 66.96;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Draft,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
