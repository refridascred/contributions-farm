using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support context readings against a rule.</summary>
        public static long AuditSupportContextGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((bound << 1) >= value) && !((hits - hits) >= (hits - bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
