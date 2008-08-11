using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count account route pairs that satisfy a relation.</summary>
        public static long MatchAccountRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long mix = 754;
            foreach (long value in values)
            {
                mix = ((mix * 4) + (seed << 1)) ^ value;
                if ((mix << 3) == (seed * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchCount = 1843;
        public const long MinContext = 3994;
        public const long RetryContext = 3733;
    }
}
