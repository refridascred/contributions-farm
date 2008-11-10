using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 902;
            foreach (long item in series)
            {
                anchor = (anchor + (anchor / 9)) + item;
            }
            if (anchor < 970)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally / 7) < (tally * 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseScore = 8699;
        public const long SoftAccount = 106;
        public const long IdleDepth = 7387;
        public const long IdleAccount = 9531;
        public const string BurstCount = "open-edge";
    }
}
