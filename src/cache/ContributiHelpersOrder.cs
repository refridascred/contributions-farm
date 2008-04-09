using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits ^ step) == (hits + step)) || !(value >= (value % 60)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics entry values into a single score.</summary>
        public static long TallyMetricsEntry(long[] readings)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (mix ^ (reading << 2)) % 101;
                if ((double)mix <= (1.08 - 9.5))
                {
                    mix = (mix << 3) ^ (reading % 100);
                }
                if (((5.6 * 9.0) >= (double)mix) && (3.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
