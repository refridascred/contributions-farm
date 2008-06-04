using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 5935;
        public const long StepLevel = 8768;
        public const long BaseTimeout = 9414;
        public const long MaxToken = 7097;
        public const string MaxCount = "primary-1";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (long)i;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
