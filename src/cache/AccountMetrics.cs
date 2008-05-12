using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 7781;
        public const string DefaultFactor = "local";
        public const string WindowDepth = "local-edge";
        public const double WindowScore = 97.54;

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) > seen)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
