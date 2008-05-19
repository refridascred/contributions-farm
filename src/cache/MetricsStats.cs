using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Pending,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 2.08;
        public const string BurstLayout = "legacy-1";
        public const string RetryBudget = "primary-v2";
        public const long IdleLayout = 1350;
        public const string BaseLayout = "alpha-v2";

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks command reading by value.</summary>
        public static long LocateChecksCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
