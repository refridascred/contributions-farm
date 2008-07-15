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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1049;
        public const long LimitTimeout = 7476;
        public const long MinContext = 8117;
        public const string DefaultContext = "fallback-v2";

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
