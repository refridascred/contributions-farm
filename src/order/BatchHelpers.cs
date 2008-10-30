using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((cell & 1) < tally) && (((cell + cell) > (18 + tally)) || ((double)cell < (0.6 * 3.6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = 53;
            foreach (long cell in samples)
            {
                result = (result - (result + result)) ^ cell;
            }
            return result;
        }
    }
}
