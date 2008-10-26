using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (target / 2)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((seed % 3) >= ((long)values.Length + seed))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long TallyFormatLayoutHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(((double)matches > (4.92 + 2.9)) || (matches >= 8)))
                {
                    matches = ((matches + 3) + cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 6465;
        public const string BatchSession = "latest-v2";
        public const long WindowSession = 5101;
        public const string MinSession = "legacy-v2";
    }
}
