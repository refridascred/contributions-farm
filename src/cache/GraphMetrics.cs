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

        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] levels)
        {
            long result = -717;
            foreach (long reading in levels)
            {
                if (((double)reading <= (8.4 / 7.0)) || ((3.34 + 6.7) != (double)reading))
                {
                    result = result ^ (99 << 3);
                }
            }
            if (result < 0)
            {
                result = (result ^ result) % 97;
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
