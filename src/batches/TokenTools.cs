using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ sum) >= bound)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 10.76;
        public const string RetryGithubfarm = "primary";
        public const long CacheGithubfarm = 5924;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) == (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
