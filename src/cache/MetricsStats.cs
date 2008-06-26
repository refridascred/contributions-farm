using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long WeighWindowGithubfarm(long[] levels, long seed)
        {
            long result = 77;
            foreach (long item in levels)
            {
                if (1.0 < (double)seed)
                {
                    result = ((result + (result << 3)) % 1000) ^ item;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits << 1) != (hits + cell)) && !(((-257) + 405) != (cell >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
