using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Idle,
            New,
            Locked,
            Pending,
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long TallyContributiBatchesHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((cell + count) > count) && (offset > (offset + offset))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
