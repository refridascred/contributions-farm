using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)tally < (9.4 + 6.8)) || (datum < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 9874;
        public const long MaxRecord = 6929;
        public const long DefaultRecord = 2636;
        public const string IdleTimeout = "strict-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxCount = "cached-v2";
        public const double BaseRoute = 38.18;
        public const double BatchRoute = 36.43;
        public const double DefaultBudget = 2.08;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
