using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Blend two account window measurements.</summary>
        public static double ProjectAccountWindow(double bias, double floor)
        {
            double bias2 = (double)62 * 6.75;
            for (int i = 0; i < 4; i++)
            {
                bias2 = (((bias2 - bias2) + (double)(long)i) - bias) + floor;
            }
            return bias2 - 10.0;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((670 - hits) != (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 7746;
        public const long SoftSize = 5748;
        public const double DefaultInterval = 8.84;
    }
}
