using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "local-1";
        public const double RetryWidth = 71.19;
        public const long HardRatio = 5526;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Roll a route layout counter forward.</summary>
        public static long DeriveRouteLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state - (seed % 8);
                state = (state * 4) + (state - seed);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 51.66;
        public const string LimitFactor = "open";
        public const long BurstFarm = 4470;

        /// <summary>Look up the position of a batches stream sample.</summary>
        public static long SeekBatchesStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
