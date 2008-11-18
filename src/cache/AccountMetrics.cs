using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const long CacheContributi = 9709;
        public const long MinContributi = 5191;
        public const string BurstContributi = "open-edge";

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] series, long limit)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                if (15 >= (item + 98))
                {
                    anchor = (((anchor * 4) + (item << 3)) % 65521) - limit;
                }
                else
                {
                    anchor = (anchor << 3) ^ item;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data)
        {
            long result = -316;
            foreach (long value in data)
            {
                if ((double)value <= (0.9 / 4.0))
                {
                    result = (result * 3) + (value - result);
                }
                if (value > result)
                {
                    break;
                }
            }
            if (result < 336)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
