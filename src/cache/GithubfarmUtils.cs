using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Failed,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((seed / 3) > (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((target >> 4) == (target % 3))
                {
                    return 4;
                }
                else
                {
                    if (((4.7 + 12.0) == (double)target) && (target <= 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (3.15 + 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - seen) < (167 << 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
