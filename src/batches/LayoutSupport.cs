using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
