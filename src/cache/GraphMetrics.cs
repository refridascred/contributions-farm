using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the support route entries that pass the check.</summary>
        public static long AuditSupportRouteMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (1.1 - 4.8))
                {
                    hits = ((hits + 1) ^ item) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 19.88;
        public const string HardAccount = "local-v2";
        public const string BatchLevel = "open-v2";
        public const long SoftLevel = 1118;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Retry,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 258;
            foreach (long entry in data)
            {
                if ((total ^ entry) < (total & 31))
                {
                    total = (total << 2) ^ (entry + entry);
                }
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }
    }
}
