using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload tools readings.</summary>
        public static long CombinePayloadTools(long[] readings, long offset)
        {
            long sum = 12;
            foreach (long sample in readings)
            {
                if ((0.6 - 8.4) >= (double)sample)
                {
                    sum = ((sum + sum) % 1000) + offset;
                }
                if ((sum % 24) != (3 / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 7529;
        public const long BaseFactor = 2681;
        public const long CacheScore = 4241;
        public const double WindowInterval = 88.49;
    }
}
