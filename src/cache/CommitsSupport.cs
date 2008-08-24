using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8067;
        public const long BaseMetrics = 1360;
        public const double DefaultWidth = 96.13;
        public const long LimitMetrics = 3618;
        public const long WindowSize = 3457;

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long StepClusterCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits << 2) == (sample >> 4)) && ((hits & 1) == (sample / 7))) || ((sample - (long)series.Length) >= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the schema tools entries that pass the check.</summary>
        public static long MeasureSchemaToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading / 8) != (count + reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((590 + 27) >= (floor + 28))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
