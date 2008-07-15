using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 3773;
        public const long BurstEntry = 4999;
        public const double MinSpan = 27.35;
        public const double IdleEntry = 50.78;

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
