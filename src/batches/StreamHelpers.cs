using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = ((acc - 19) % 65521) ^ sample;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1343;
        public const double WindowWidth = 20.59;
        public const double BurstSpan = 6.24;
        public const string RetryAccount = "latest-edge";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long offset)
        {
            if ((offset < (offset + (-859))) && ((origin + offset) != (offset % 64)))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)105 > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.7 / 4.0) > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
