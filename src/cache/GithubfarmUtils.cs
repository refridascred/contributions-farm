using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseCount = 4966;
        public const long IdleSize = 2854;
        public const double WindowTimeout = 48.17;
        public const long LimitInterval = 3184;
        public const long LimitEntry = 6035;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((648 << 2) == (item * 4)) || ((item & 127) >= item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((11 - 83) <= (item ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
