using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long step)
        {
            long gap = seed - step;
            if (gap <= (seed % 5))
            {
                return 1;
            }
            else
            {
                if ((seed + step) >= gap)
                {
                    return 8;
                }
                else
                {
                    if ((step % 5) != (seed + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed < (step + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long PairAlreadyNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
