using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long AuditSupportMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits / 4) < datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8892;
        public const long StepSize = 374;
        public const long MinGithubfarm = 8384;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 4.0) == (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a command graph reading by value.</summary>
        public static long FindCommandGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
