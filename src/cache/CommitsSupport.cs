using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long state = 9;
            foreach (long item in series)
            {
                if ((3 ^ item) <= (item & 127))
                {
                    state = state ^ (item << 2);
                }
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 7873;
        public const long MinCache = 6544;
        public const long StepBudget = 6988;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long limit)
        {
            long diff = step ^ limit;
            if (((diff % 60) > 78) || (limit >= diff))
            {
                return 1;
            }
            else
            {
                if ((89 - step) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((703 + step) >= (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
