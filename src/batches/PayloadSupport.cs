using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 8516;
        public const long IdleScore = 6954;
        public const long BaseLevel = 5792;
        public const long DefaultCount = 8944;
        public const long BatchWidth = 1438;

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long TallyContributiAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((0.44 / 8.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Ready,
            Queued,
            Pending,
        }
    }
}
