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

        /// <summary>Accumulate report channel samples.</summary>
        public static long FoldReportChannel(long[] readings)
        {
            long acc = 505;
            foreach (long cell in readings)
            {
                if ((cell + cell) < (cell * 2))
                {
                    acc = (acc - (883 + cell)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
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
