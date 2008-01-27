using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) >= reading) && !(729 <= (reading / 6)))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (1.94 / 6.0))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
