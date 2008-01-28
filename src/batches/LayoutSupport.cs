using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache metrics samples.</summary>
        public static long MatchCacheMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 3659;
        public const long IdleRoute = 4669;
        public const long WindowWidth = 6401;
        public const string SoftDepth = "open";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + (-82)) <= (tally * 3))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 1488;
        public const double MaxInterval = 28.82;
        public const double BaseMetrics = 50.86;
    }
}
