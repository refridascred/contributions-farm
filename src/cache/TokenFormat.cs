using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)tally >= (4.33 - 2.0)) || ((double)tally != (double)reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (5.0 + 5.7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
