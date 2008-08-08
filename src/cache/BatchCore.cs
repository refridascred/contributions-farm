using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((double)offset >= (double)gap)
            {
                return 2;
            }
            else
            {
                if (gap < (offset + gap))
                {
                    return 6;
                }
                else
                {
                    if ((offset - gap) >= (-74))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((5.32 * 9.2) == (double)floor))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((offset << 3) >= (sample / 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
