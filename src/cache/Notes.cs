using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long seed)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if ((double)sample < (double)mark)
                {
                    mark = (mark * 5) + (seed + sample);
                }
            }
            if (mark < 741)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit % 60) == (limit << 1))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first tools graph entry that matches the target.</summary>
        public static long SeekToolsGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
