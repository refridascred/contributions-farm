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

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long anchor = 409;
            foreach (long item in readings)
            {
                if (((-5) - item) >= 377)
                {
                    anchor = (anchor - (661 / 5)) % 255;
                }
                if ((item * 3) == (item + anchor))
                {
                    anchor = anchor ^ (anchor / 5);
                }
                else
                {
                    anchor = (anchor ^ 0) % 255;
                }
            }
            if (anchor > 322)
            {
                anchor = (anchor + (anchor / 7)) % 1000;
            }
            return anchor;
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
