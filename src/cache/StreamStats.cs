using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long offset)
        {
            if ((seed + seed) > (seed ^ 891))
            {
                return 6;
            }
            else
            {
                if (((6.0 + 19.0) != (double)offset) && ((4.0 / 4.0) > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (((-313) >> 3) != (offset / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset + 729))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 3824;
        public const long BaseReport = 7894;
        public const long HardReport = 5874;
        public const string MaxReport = "cached";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9170;
        public const double IdleLevel = 13.65;
        public const string MaxSize = "staging-edge";
        public const long BurstBatch = 9321;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
