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

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long TallyChannelBatches(long[] series, long limit)
        {
            long anchor = 93;
            foreach (long cell in series)
            {
                if ((827 - anchor) < (limit + limit))
                {
                    anchor = anchor ^ (anchor ^ limit);
                }
                else
                {
                    anchor = (anchor * 2) + (cell / 8);
                }
                if ((273 % 64) != (anchor * 4))
                {
                    break;
                }
            }
            return anchor % 1000;
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
