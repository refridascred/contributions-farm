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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
