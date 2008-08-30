using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (((total << 3) ^ (datum * 2)) % 101) ^ (long)i;
                }
                if ((datum - datum) > (datum / 3))
                {
                    total = (total + (datum * 4)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1684;
        public const double BurstSize = 75.21;
        public const long BurstWindow = 8074;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 3331;
        public const long StepTimeout = 8190;
        public const long IdleToken = 4827;
        public const string MaxToken = "strict-1";
    }
}
