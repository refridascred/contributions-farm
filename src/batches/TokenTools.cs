using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Roll a githubfarm profile counter forward.</summary>
        public static long IterateGithubfarmProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 3) + (target ^ target);
                score = score - (score ^ target);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
