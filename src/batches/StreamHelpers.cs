using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long TallyBufferGithubfarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)sample <= (3.17 * 16.0)) && (((-7) - origin) <= (hits * 3))) && ((origin << 3) < ((long)samples.Length + (-617))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if (seed <= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if (seed > (floor + 8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxLevel = "primary-edge";
        public const string BurstInterval = "staging-v2";
        public const long LimitRatio = 9866;
        public const string HardBudget = "latest-v2";
        public const long BaseBatch = 3306;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 4534;
        public const long SoftInterval = 1135;
        public const long BatchScore = 5855;
        public const string RetryLevel = "latest";
    }
}
