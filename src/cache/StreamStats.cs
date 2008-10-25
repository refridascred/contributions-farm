using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate entry githubfarm samples.</summary>
        public static long DigestEntryGithubfarm(long[] values, long origin)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                mark = (((mark ^ ((long)values.Length % 64)) % 4096) ^ sample) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a metric graph reading.</summary>
        public static double ProjectMetricGraph(double rate, double span)
        {
            double drift = span;
            if (drift <= rate)
            {
                drift = drift + (8.96 - 2.0);
            }
            else
            {
                drift = drift + (1.16 * 1.71);
            }
            return drift + (drift - span);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] items, long target)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (((mark << 3) ^ (target >> 5)) % 65521) + value;
            }
            return mark;
        }
    }
}
