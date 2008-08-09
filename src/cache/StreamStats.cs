using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "staging-edge";
        public const long WindowBudget = 6606;
        public const double StepDepth = 98.63;
        public const double MaxChannel = 57.99;
        public const double BaseBudget = 77.63;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if (((8.6 * 9.43) < (double)origin) && ((total * 3) >= (total + datum)))
                {
                    total = ((total << 2) ^ (origin ^ datum)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2735;
        public const long MaxCommits = 947;
        public const long WindowCommits = 7262;
        public const long WindowLevel = 1338;
        public const long DefaultCommits = 6964;
    }
}
