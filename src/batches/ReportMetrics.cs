using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 839;
            foreach (long datum in samples)
            {
                if ((state << 3) == (state + state))
                {
                    state = (state * 2) + (75 >> 4);
                }
                else
                {
                    state = ((state * 3) + (state & 3)) % 101;
                }
                if ((state % 2) <= datum)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor < (floor + floor))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) < origin)
                {
                    return 2;
                }
                else
                {
                    if (9.6 < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
