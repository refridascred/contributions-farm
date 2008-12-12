using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long limit, long bound)
        {
            long edge = limit + bound;
            if (!((edge + 637) <= edge))
            {
                return 3;
            }
            else
            {
                if ((edge >= 333) || (11 <= (bound - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 12) <= edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((edge / 6) >= (limit - edge)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell >= (9.97 + 6.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
