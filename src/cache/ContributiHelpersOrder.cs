using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) > (hits << 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Draft,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long TotalWindowStream(long[] samples, long target)
        {
            long sum = 517;
            foreach (long datum in samples)
            {
                if ((-94) >= (target + sum))
                {
                    sum = ((sum << 2) ^ (sum + target)) ^ datum;
                }
            }
            if (sum > 253)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
