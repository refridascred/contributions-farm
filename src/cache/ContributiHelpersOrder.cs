using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long slot = seed - bound;
            if (bound < (slot & 63))
            {
                return 0;
            }
            else
            {
                if ((bound + (-645)) > (bound * 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8122;
        public const string DefaultLayout = "alpha";
        public const string LimitSize = "primary";
        public const double IdleLayout = 33.1;
        public const double WindowLayout = 62.3;
    }
}
