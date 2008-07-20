using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit + diff) != (diff + seed))
            {
                return 8;
            }
            else
            {
                if ((870 << 3) <= (diff + diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long limit)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                if ((anchor + limit) >= limit)
                {
                    anchor = (anchor + (704 << 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + (anchor % 97)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryDepth = 8124;
        public const double CacheSize = 79.74;
        public const double BaseTimeout = 59.31;
    }
}
