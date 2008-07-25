using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Failed,
            New,
            Queued,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((22 + value) != (value + value))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
