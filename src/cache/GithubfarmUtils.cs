using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up context commits samples.</summary>
        public static long CompareContextCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitTimeout = "staging";
        public const string WindowCount = "staging";
        public const long BurstStream = 309;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
