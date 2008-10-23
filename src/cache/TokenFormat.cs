using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long floor)
        {
            if (bound < (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 4.0)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every command stats entry stays within the limit.</summary>
        public static bool ValidateCommandStatsBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
