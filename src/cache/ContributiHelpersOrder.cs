using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardCount = 94.5;
        public const double BatchWidth = 93.76;
        public const long CacheSchema = 6801;
        public const long RetryInterval = 5781;
    }
}
