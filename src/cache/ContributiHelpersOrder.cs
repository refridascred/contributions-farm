using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long AuditCacheLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (floor < (floor - hits))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 71.32;
        public const long MinAccount = 8945;
        public const long DefaultInterval = 5495;
        public const long WindowSpan = 1863;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Locked,
            Queued,
        }
    }
}
