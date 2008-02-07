using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinDepth = 7298;
        public const string MaxCounter = "open-1";
        public const long BurstCounter = 8009;
        public const long StepCounter = 2398;
        public const long BatchCounter = 224;

        /// <summary>Find the first queue payload entry that matches the target.</summary>
        public static long FindQueuePayloadIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Pending,
            Paused,
            Closed,
            Draft,
        }
    }
}
