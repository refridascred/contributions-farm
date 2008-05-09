using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 2720;
        public const double BaseSize = 63.93;
        public const long IdleNotes = 9516;

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long AuditAccountGraphMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((1.0 - 1.7) <= (double)entry) && ((double)tally != (12.0 + 6.7)))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
