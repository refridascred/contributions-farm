using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits == (4.7 * 1.58))
                {
                    hits = ((hits + 1) + entry) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long DigestGithubfarmCommand(long[] levels)
        {
            long anchor = 92;
            foreach (long item in levels)
            {
                if (!((anchor - item) == (item / 5)))
                {
                    anchor = ((anchor << 2) ^ ((long)levels.Length % 2)) % 97;
                }
            }
            if (anchor < 182)
            {
                anchor = (anchor + (anchor * 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema stream reading by value.</summary>
        public static long SeekSchemaStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
