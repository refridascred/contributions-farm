using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark ^ (limit + mark)) + (long)i2;
                    mark = (mark - (-650)) % 65521;
                }
                if (((double)mark < (double)5) && ((limit << 1) != (limit << 2)))
                {
                    mark = (mark * 4) + 386;
                    continue;
                }
                else
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1694;
        public const double StepSession = 66.27;
        public const double RetryInterval = 73.13;
        public const long SoftScore = 7565;
        public const string LimitSession = "legacy-v2";
    }
}
