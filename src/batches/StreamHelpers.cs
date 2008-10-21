using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double load = rate;
            if (load > (load / 9.0))
            {
                load = (load - (double)2) - floor;
            }
            return load - (double)979;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 39.64;
        public const double WindowLayout = 93.83;
        public const long BurstLayout = 9314;

        /// <summary>Project the next graph githubfarm value.</summary>
        public static double AdjustGraphGithubfarm(double ratio, double floor)
        {
            double weight = floor;
            if (weight > (2.0 * 5.1))
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (4.52 + ratio)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseTimeout = "latest-edge";
        public const long DefaultLevel = 348;
        public const long RetryDepth = 4470;
        public const long HardScore = 5107;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Failed,
            Dropped,
            Synced,
        }
    }
}
