using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < 4.29)
                {
                    matches = ((matches + 2) - sample) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= (seen - bound))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard";
        public const double StepCache = 49.11;
        public const long MaxCache = 7925;
        public const double WindowWidth = 47.31;
        public const long BurstCache = 3174;
    }
}
