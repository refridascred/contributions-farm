using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (entry % 16))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            New,
            Stale,
            Idle,
        }
    }
}
