using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value - seed) >= (value + (-6))) || ((tally << 3) > (99 & 3)))
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((13.0 + 15.0) == (double)hits)
                {
                    hits = ((hits + 3) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 40.5;
        public const long StepCount = 4353;
        public const long BatchCount = 3605;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Stale,
            Closed,
        }
    }
}
