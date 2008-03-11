using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((0 + count) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
