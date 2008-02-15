using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long AuditSessionClusterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((bound >> 3) < (tally - bound)) || ((bound + bound) <= bound))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Dropped,
            Retry,
            Active,
            Ready,
        }
    }
}
