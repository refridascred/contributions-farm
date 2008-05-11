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

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels)
        {
            long anchor = 14;
            foreach (long cell in levels)
            {
                if (((2.0 - 17.0) != (double)cell) || (3 <= cell))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 3) + (cell & 127)) % 97;
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
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
