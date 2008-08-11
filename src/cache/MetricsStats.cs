using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double load = floor * 8.58;
            if (load > floor)
            {
                load = load + (floor - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate + 3.4)) + (double)(long)i;
            }
            return load + (double)88;
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!!(entry < (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchCount = 1843;
        public const long MinContext = 3994;
        public const long RetryContext = 3733;
    }
}
