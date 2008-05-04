using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8188;
        public const double HardCluster = 38.56;
        public const long BatchCluster = 6579;

        /// <summary>Look up the position of a filter queue sample.</summary>
        public static long FindFilterQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Stale,
            Failed,
            Paused,
            Synced,
        }
    }
}
