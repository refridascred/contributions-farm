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

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySpan = 33.92;
        public const string StepRoute = "standard-1";
        public const long StepSpan = 8619;
        public const string CacheSize = "standard";
        public const long SoftRoute = 856;

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
