using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "fallback";
        public const long MaxSpan = 7659;
        public const long BurstTimeout = 2792;
        public const string BaseSession = "legacy";
        public const long BurstWidth = 5606;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 8.0))
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (7.11 / 4.0)) + (double)(long)i;
            }
            return ratio2 + (bias - bias);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 5356;
        public const string MinRatio = "fallback-edge";
        public const long CacheSize = 4342;
        public const long SoftChecks = 5649;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 4.69;
        public const double RetryLevel = 68.39;
        public const long CacheSpan = 4082;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Dropped,
            Done,
        }
    }
}
