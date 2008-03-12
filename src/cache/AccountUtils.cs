using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (6 >= seen)
                {
                    seen = ((seen + 3) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Draft,
            Retry,
            Failed,
            Pending,
        }
    }
}
