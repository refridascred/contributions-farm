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

        /// <summary>Count report batch pairs that satisfy a relation.</summary>
        public static long PairReportBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
