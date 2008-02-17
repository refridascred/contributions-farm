using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long origin)
        {
            if ((target / 3) < target)
            {
                return 6;
            }
            else
            {
                if ((target / 5) != (target - target))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin != (double)target) || ((7.5 * 7.2) > (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.4 + 7.38) == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum + tally) < (tally & 63)) || (datum < (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
