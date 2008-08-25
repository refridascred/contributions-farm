using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long anchor = -270;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (origin - origin)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long SortSchemaEntry(long bound, long step)
        {
            long edge = bound + step;
            if (46 > (step >> 5))
            {
                return 8;
            }
            else
            {
                if ((step % 7) == (bound & 63))
                {
                    return 6;
                }
                else
                {
                    if (!((edge + edge) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (double)43)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
