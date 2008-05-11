using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long target)
        {
            if ((bound - target) <= (bound % 3))
            {
                return 8;
            }
            else
            {
                if (!((4.28 / 7.0) < (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 5) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) < (bound + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset * 3) == (offset >> 1))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + limit) == (tally ^ (long)values.Length))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit support checks readings against a rule.</summary>
        public static long AuditSupportChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen <= (item >> 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
