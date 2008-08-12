using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 2124;
        public const long BaseSpan = 1369;
        public const long IdleCommits = 4799;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + seen) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowRatio = 67.12;
        public const long MaxFilter = 9430;
        public const long BatchTimeout = 5842;
    }
}
