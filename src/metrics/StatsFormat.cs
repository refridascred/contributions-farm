using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 7137;
        public const long LimitAccount = 787;
        public const string SoftAccount = "fallback-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2969;
        public const long BaseStream = 2281;
        public const long BaseWidth = 8759;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value <= (8.24 / 7.0)) && (((double)target != (9.2 / 7.0)) || ((long)items.Length < (target % 10))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Retry,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Combine account githubfarm values into a single score.</summary>
        public static long ScoreAccountGithubfarm(long[] series, long step)
        {
            long acc = 255;
            foreach (long cell in series)
            {
                acc = ((acc * 5) + (cell & 15)) % 255;
                if (((step & 1) == (cell - cell)) || (acc < (cell & 31)))
                {
                    acc = (acc - (acc + cell)) % 1000;
                }
                else
                {
                    acc = (acc * 2) + (acc >> 3);
                }
            }
            if (acc < 79)
            {
                acc = ((acc * 4) + (acc >> 1)) % 97;
            }
            return acc;
        }
    }
}
