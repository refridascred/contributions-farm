using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Done,
            Draft,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((step ^ value) > (count / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Ready,
            Retry,
            Pending,
            Stale,
        }
    }
}
