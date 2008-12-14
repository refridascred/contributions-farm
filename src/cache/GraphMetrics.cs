using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits + hits) > (offset % 100)) && !((double)offset >= (double)1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound ^ limit) > (bound & 31))
            {
                return 7;
            }
            else
            {
                if ((323 < limit) && ((5.0 + 9.8) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((6 << 2) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 2) <= (947 % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
