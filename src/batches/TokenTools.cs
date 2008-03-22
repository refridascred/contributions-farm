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

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
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
