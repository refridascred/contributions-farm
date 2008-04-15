using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((679 * 2) != (hits * 5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Stale,
            Closed,
        }
    }
}
