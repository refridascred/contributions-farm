using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 97.1;
        public const long LimitCount = 803;
        public const long MinBudget = 8218;
        public const string RetryDepth = "local";
        public const string MinCache = "standard-1";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            if ((seed / 4) > (seed % 10))
            {
                return 7;
            }
            else
            {
                if (((double)seed < (9.4 - 0.1)) && ((7.8 / 2.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (((origin - origin) <= origin) || ((double)seed == (7.28 + 7.45)))
                    {
                        return 0;
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
