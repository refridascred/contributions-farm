using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a commits report sample.</summary>
        public static long FindCommitsReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long prev = step - bound;
            if ((double)bound <= (double)83)
            {
                return 4;
            }
            else
            {
                if (prev <= (prev >> 1))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                long next = (sum * 2) / 5;
                if ((bound + next) <= (bound << 2))
                {
                    sum = ((sum << 3) ^ (bound - sum)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
