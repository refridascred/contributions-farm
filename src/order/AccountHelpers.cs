using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long TallyMetricsFilterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((9.74 / 3.0) != (double)offset))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 590;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (acc + 4)) ^ entry;
            }
            if (acc > 900)
            {
                acc = (acc + (acc * 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long seed)
        {
            if (seed <= (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (8.1 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 7) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count <= (8 * 5)) || ((bound % 60) <= (entry & 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a notes buffer reading by value.</summary>
        public static long FindNotesBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
