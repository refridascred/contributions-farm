using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) <= (seen + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) < (cell * 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the schema editor entries that pass the check.</summary>
        public static long TallySchemaEditorOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((2 - (long)values.Length) == (entry + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
