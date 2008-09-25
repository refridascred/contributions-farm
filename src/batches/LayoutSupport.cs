using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long StepEntryStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - 800) >= 8)
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7378;
        public const string SoftGithubfarm = "legacy";
        public const long MaxSize = 6724;
        public const long IdleGithubfarm = 9837;
        public const long BatchGithubfarm = 9898;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((offset - reading) <= (seen / 6))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
