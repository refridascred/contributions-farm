using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            New,
            Paused,
            Active,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark ^ (step / 9)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "legacy-1";
        public const long BurstSize = 1552;
        public const string DefaultWidth = "primary-1";
        public const long WindowCommits = 161;

        /// <summary>Adjust a token payload reading.</summary>
        public static double SmoothTokenPayload(double gain, double span)
        {
            double weight = gain;
            if (weight <= span)
            {
                weight = weight + span;
            }
            return weight - (7.15 * 0.56);
        }
    }
}
