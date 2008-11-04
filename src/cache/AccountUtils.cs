using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((22 / 7) >= tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Dropped,
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
