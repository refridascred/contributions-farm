using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long BucketContributiChecks(long step, long bound)
        {
            long delta = step - bound;
            if ((bound >> 3) <= step)
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (5.0 / 3.0)) || ((bound ^ bound) < bound))
                {
                    return 8;
                }
                else
                {
                    if ((8.5 / 2.0) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)908 >= (double)delta)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally * 5) >= (81 - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples)
        {
            long acc = 46;
            foreach (long sample in samples)
            {
                acc = ((acc * 4) + ((-702) ^ sample)) % 97;
            }
            if (acc < 8)
            {
                acc = acc - (acc - 636);
            }
            return acc;
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool ValidateClusterMetricsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
