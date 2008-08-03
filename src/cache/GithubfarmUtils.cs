using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 4269;
        public const long SoftCount = 9649;
        public const double MinDepth = 56.55;
        public const long MinStats = 477;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen < 1.4)
                {
                    seen = ((seen + 3) - entry) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (1.56 * 16.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
