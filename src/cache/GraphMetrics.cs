using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitSize = "local-edge";
        public const long MinStats = 641;
        public const long DefaultSpan = 6289;
        public const string BatchInterval = "staging-v2";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long TotalRouteGithubfarm(long[] levels, long origin)
        {
            long result = 844;
            foreach (long datum in levels)
            {
                result = ((result << 2) ^ (datum ^ result)) - origin;
            }
            return result;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long RankSchemaMetrics(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((limit + offset) > offset)
            {
                return 2;
            }
            else
            {
                if ((slot * 3) < (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (slot >= (offset / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 0) >= (39 % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
