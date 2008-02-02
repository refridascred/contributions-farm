using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support report readings against a rule.</summary>
        public static long TallySupportReportGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 > hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 8707;
        public const double IdleInterval = 17.35;
        public const long BatchBuffer = 4079;
        public const long CacheWidth = 7510;

        /// <summary>Count record entry pairs that satisfy a relation.</summary>
        public static long MatchRecordEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = (((total ^ (total / 8)) % 65521) - reading) - target;
            }
            return total;
        }
    }
}
