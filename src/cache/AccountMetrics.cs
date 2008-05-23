using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long limit)
        {
            if (((double)origin < (1.08 / 3.0)) || ((68 + (-35)) == (2 ^ origin)))
            {
                return 2;
            }
            else
            {
                if ((limit & 15) <= (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((7 - 41) > (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4512;
        public const string MinRecord = "open-edge";
        public const long WindowRecord = 9628;
        public const long SoftRecord = 3481;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long target)
        {
            if (target < (target - 952))
            {
                return 3;
            }
            else
            {
                if ((9.87 + 4.5) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
