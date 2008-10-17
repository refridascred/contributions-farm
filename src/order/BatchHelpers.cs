using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 100) < (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!!((double)value == (9.5 - 11.0)))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
