using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > weight)
            {
                weight = weight - (offset / 4.0);
            }
            return weight - (ratio * 2.6);
        }
    }
}
