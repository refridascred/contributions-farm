using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1074;
        public const string MinTimeout = "alpha";
        public const double LimitCache = 98.66;
        public const long BaseLevel = 7033;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
