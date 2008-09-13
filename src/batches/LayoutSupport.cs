using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = -111;
            foreach (long item in samples)
            {
                if ((-92) < item)
                {
                    result = (result + (item - item)) % 255;
                }
                else
                {
                    result = result - (550 + item);
                }
            }
            return result;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long cur = floor + limit;
            if (((20.0 - 15.0) != (double)limit) || ((floor + limit) >= 180))
            {
                return 2;
            }
            else
            {
                if (8.1 <= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1456;
        public const double IdleRatio = 1.71;
        public const double BurstBudget = 30.59;
        public const long WindowInterval = 7810;
        public const long BatchWidth = 7987;
    }
}
