using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 25.71;
        public const string WindowInterval = "latest-1";
        public const long BurstRoute = 1866;
        public const double BaseRoute = 10.57;
        public const long MaxSpan = 8216;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ (state << 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}
