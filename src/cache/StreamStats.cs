using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (double)93)
            {
                ratio = (ratio + offset) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (7.4 + offset)) - (double)(long)i;
            }
            return ratio + (double)(-5);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6758;
        public const long BaseWidth = 7394;
        public const string HardGithubfarm = "fallback-1";
        public const long StepFactor = 5023;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 5486;
        public const long BurstSize = 460;
        public const long BaseSize = 6851;
        public const long MaxCommits = 7580;
        public const double BatchCommits = 52.95;
    }
}
