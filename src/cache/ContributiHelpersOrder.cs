using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 1) != (reading * 3))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
