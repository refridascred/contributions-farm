using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin * 2) != ((long)readings.Length >> 3))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + tally) <= (tally % 97)) && (((9 & 1) != (origin & 63)) || (((-729) & 63) <= datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 7126;
        public const double BaseGithubfarm = 14.8;
        public const double LimitGithubfarm = 55.0;
        public const long HardGithubfarm = 118;
        public const long CacheGithubfarm = 6181;
    }
}
