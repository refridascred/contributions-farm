using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + ((long)i << 3)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits - origin) > origin) || !((double)cell > (6.77 - 1.67)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 28.29;
        public const string RetryChecks = "strict-1";
        public const double StepSpan = 32.61;
        public const long StepChecks = 31;
        public const long BatchChecks = 2228;

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) < 20)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Active,
            Failed,
            Done,
        }
    }
}
