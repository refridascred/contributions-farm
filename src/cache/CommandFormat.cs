using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long TallyCommitsReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits ^ reading) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheDepth = 3779;
        public const double StepChecks = 84.22;
        public const string MaxTimeout = "primary-v2";
        public const long MaxChecks = 221;
        public const long MinChecks = 3356;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            if ((double)limit2 == (18.0 - 6.6))
            {
                return 5;
            }
            else
            {
                if (((6.8 / 2.0) >= (double)limit) && ((limit - limit2) <= limit2))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit2) == (limit % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
