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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (2.3 <= (double)count)
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
