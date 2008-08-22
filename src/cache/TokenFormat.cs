using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = target * 2;
                delta = delta + delta;
                if (!(delta <= ((long)i % 16)))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - seed) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
