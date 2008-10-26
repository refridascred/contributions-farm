using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "staging-edge";
        public const double BatchScore = 47.91;
        public const double IdleScore = 70.03;
        public const double DefaultScore = 65.61;
    }
}
