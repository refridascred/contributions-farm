using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowSpan = "cached-1";
        public const double BaseCommits = 75.56;
        public const string WindowCount = "cached-v2";
        public const long DefaultCommits = 4591;
        public const string RetryLevel = "standard";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long origin)
        {
            long gap = limit ^ origin;
            if ((limit + 163) < (270 & 1))
            {
                return 5;
            }
            else
            {
                if ((8.52 * 1.39) >= (double)gap)
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
