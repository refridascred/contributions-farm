using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate schema report samples.</summary>
        public static long ScoreSchemaReport(long[] readings, long offset)
        {
            long total = 406;
            foreach (long value in readings)
            {
                if ((0.22 - 6.0) >= (double)total)
                {
                    total = (total + (total / 4)) - value;
                }
            }
            if (total > 1)
            {
                total = total ^ (offset - (long)readings.Length);
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheSize = "legacy";
        public const long MinNotes = 7580;
        public const long HardInterval = 4064;
        public const long SoftSpan = 9676;
        public const long IdleNotes = 7632;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5 - hits) > (597 & 1))
                {
                    hits = ((hits + 3) ^ value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxSize = "fallback-v2";
        public const double BaseSize = 82.53;
        public const long DefaultSize = 1489;
    }
}
