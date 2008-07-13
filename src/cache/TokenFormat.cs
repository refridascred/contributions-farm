using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
