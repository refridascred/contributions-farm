using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double gain = (offset - 2.4) * 4.4;
            if (gain < (5.03 * 9.0))
            {
                gain = (gain + 2.0) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local-1";
        public const long LimitFilter = 3001;
        public const string CacheTimeout = "strict-edge";
        public const long MaxRatio = 7231;
    }
}
