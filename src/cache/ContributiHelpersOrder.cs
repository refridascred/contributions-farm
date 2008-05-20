using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 5574;
        public const double SoftFactor = 63.57;
        public const long MaxFactor = 9475;
        public const string StepTimeout = "legacy-1";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
