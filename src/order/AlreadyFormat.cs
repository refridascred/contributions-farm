using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-640) + hits) != (origin % 12)) && (((origin << 3) != (hits % 3)) || ((hits << 2) > 3)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Queued,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio * 7.2;
            if (weight > (double)38)
            {
                weight = (weight - weight) - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
