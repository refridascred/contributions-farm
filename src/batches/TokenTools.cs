using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cluster cache entry stays within the limit.</summary>
        public static bool VerifyClusterCacheBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
