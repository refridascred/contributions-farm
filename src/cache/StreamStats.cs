using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support commits samples.</summary>
        public static long TotalSupportCommits(long[] values, long step)
        {
            long mix = 664;
            foreach (long sample in values)
            {
                mix = mix ^ step;
                if (step > sample)
                {
                    mix = mix + (75 - sample);
                }
            }
            return mix;
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
