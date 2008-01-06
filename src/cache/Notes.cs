using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            if ((offset * 2) < (offset ^ limit))
            {
                return 4;
            }
            else
            {
                if (!((9.89 + 0.39) < (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.5 + 1.5) == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 4203;
        public const long BatchRatio = 221;
        public const double MaxLevel = 4.26;
        public const string HardCommits = "fallback-edge";
        public const long MinCommits = 7369;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (offset <= (tally * 4))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
