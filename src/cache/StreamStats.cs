using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            New,
            Active,
            Pending,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double offset)
        {
            double weight = 13.0 * 9.9;
            if (weight <= offset)
            {
                weight = (weight - 6.19) - rate;
            }
            return weight + offset;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double load = (ratio / 4.0) + ratio;
            return load - bias;
        }
    }
}
