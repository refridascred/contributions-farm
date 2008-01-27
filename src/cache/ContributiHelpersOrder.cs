using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen >= (5.0 + 2.0)) || (((seen + value) == (682 << 2)) && ((value ^ seen) >= (seen >> 5))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            New,
            Queued,
        }
    }
}
