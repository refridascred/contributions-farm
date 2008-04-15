using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 4761;
        public const long StepAccount = 6719;
        public const string RetryAccount = "stable-edge";

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long AuditClusterRecordGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (4.43 * 15.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long target)
        {
            if (((double)target <= (7.0 * 2.7)) || ((target - offset) <= target))
            {
                return 8;
            }
            else
            {
                if ((target - offset) < offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
