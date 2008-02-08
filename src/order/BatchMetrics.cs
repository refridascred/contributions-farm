using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits == (4.7 * 1.58))
                {
                    hits = ((hits + 1) + entry) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + floor) <= (620 + floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
