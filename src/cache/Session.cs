using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) != (402 % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window report entry that matches the target.</summary>
        public static long LookupWindowReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinRatio = 66.89;
        public const long CacheFilter = 6649;
        public const long WindowWidth = 2819;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
