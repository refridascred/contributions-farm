using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 6945;
        public const long IdleBuffer = 3131;
        public const long MaxBuffer = 4538;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long origin)
        {
            if (5.0 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (((origin + floor) >= (floor & 63)) || (95 >= origin))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = (acc - (acc << 2)) - sample;
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
