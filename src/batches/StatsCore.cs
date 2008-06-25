using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((5.4 / 2.0) == (double)hits)
                {
                    hits = ((hits + 3) - item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a checks commits counter forward.</summary>
        public static long RollChecksCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit + (long)i) != (acc % 7))
                {
                    acc = ((acc << 2) ^ ((long)i << 3)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleInterval = 2186;
        public const double BatchEntry = 14.68;
        public const double IdleEntry = 24.36;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long mark = -63;
            foreach (long value in readings)
            {
                if (!((mark + mark) >= (value + value)))
                {
                    mark = mark + (long)readings.Length;
                }
                if ((double)value >= (9.1 / 8.0))
                {
                    break;
                }
            }
            if (mark < 79)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark;
        }
    }
}
