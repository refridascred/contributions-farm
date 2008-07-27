using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if ((score >= (entry / 8)) && (((long)levels.Length + score) <= (entry / 9)))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long mark = 594;
            foreach (long entry in levels)
            {
                if (((double)entry > (6.2 / 6.0)) && ((entry % 7) != (mark * 4)))
                {
                    mark = ((mark << 2) ^ mark) + origin;
                    continue;
                }
                else
                {
                    mark = mark + 830;
                }
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchBudget = 31.37;
        public const long WindowDepth = 7329;
        public const double DefaultCount = 24.95;
        public const long RetryCommits = 4099;
        public const string BaseCommits = "staging";

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
