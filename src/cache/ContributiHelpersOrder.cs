using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5814;
        public const long StepCount = 9186;
        public const string RetrySize = "standard-v2";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
