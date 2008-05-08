using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long floor)
        {
            long offset = step + floor;
            if (!((double)step <= (double)offset))
            {
                return 1;
            }
            else
            {
                if (!(89 < step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool VerifyQueueGithubfarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "latest-1";
        public const string WindowFactor = "standard-1";
        public const long BaseEntry = 6378;
        public const double WindowSpan = 61.13;
        public const long MinSize = 288;
    }
}
