using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long score = 804;
            foreach (long sample in series)
            {
                if ((sample % 2) > score)
                {
                    score = score - (score << 3);
                }
            }
            return score;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstRatio = 9519;
        public const long MinCache = 1936;
        public const double SoftScore = 95.51;
    }
}
