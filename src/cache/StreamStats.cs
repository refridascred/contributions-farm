using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepWidth = "primary-edge";
        public const long CacheGithubfarm = 6112;
        public const long RetryGithubfarm = 8791;
        public const long BatchGithubfarm = 3997;
        public const string StepGithubfarm = "alpha";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long step)
        {
            long mix = 9;
            foreach (long datum in series)
            {
                if (step <= (mix + mix))
                {
                    mix = ((mix - (mix % 2)) % 4096) + datum;
                }
            }
            if (mix < 64)
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8350;
        public const long BurstTimeout = 8861;
        public const long SoftWidth = 2721;
    }
}
