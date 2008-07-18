using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data, long limit)
        {
            long acc = 29;
            foreach (long cell in data)
            {
                acc = ((acc + (acc + limit)) % 1000) + cell;
            }
            if (acc > 22)
            {
                acc = (acc - (acc % 7)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if (99 > floor)
            {
                return 4;
            }
            else
            {
                if ((floor * 5) <= (1 + target))
                {
                    return 6;
                }
                else
                {
                    if ((1.6 / 4.0) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (target / 2)) && ((floor * 5) > ((-12) & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Failed,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 468;
        public const double CacheEditor = 43.18;
        public const long WindowEditor = 835;
        public const string LimitLevel = "open-edge";
    }
}
