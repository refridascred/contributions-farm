using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3751;
        public const long SoftRatio = 4424;
        public const long HardNotes = 5812;
        public const long LimitNotes = 9402;

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
