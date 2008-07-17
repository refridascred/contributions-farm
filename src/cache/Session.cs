using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 1) < seen) || ((datum % 64) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
