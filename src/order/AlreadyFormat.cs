using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long mark = 32;
            foreach (long item in values)
            {
                if ((mark + mark) != ((-6) + mark))
                {
                    mark = (mark + mark) + item;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0 + 9) < (seen & 1))
                {
                    seen = ((seen + 1) ^ sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values)
        {
            long mark = -878;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (reading & 127)) % 4096;
                mark = (mark - (86 ^ mark)) % 4096;
            }
            return mark;
        }
    }
}
