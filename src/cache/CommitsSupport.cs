using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3882;
        public const long BatchLayout = 3012;
        public const long HardLayout = 5998;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - ((long)i / 4)) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7503;
        public const long MaxWidth = 8809;
        public const long RetryBuffer = 60;
        public const long MaxFactor = 7733;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long bound2)
        {
            if (!(6.0 > (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound2 <= (822 << 1)) || ((bound2 % 24) <= (-763)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Stale,
            Idle,
            Ready,
        }
    }
}
