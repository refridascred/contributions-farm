using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 41.19;
        public const long IdleContributi = 7630;
        public const string MinContributi = "alpha-edge";

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long seed)
        {
            long sum = 22;
            foreach (long datum in levels)
            {
                if ((8.2 / 7.0) != (double)seed)
                {
                    sum = ((sum << 3) ^ (datum - 76)) % 255;
                }
                else
                {
                    sum = (sum - (474 - sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long origin)
        {
            long score = -1;
            foreach (long entry in readings)
            {
                score = score - (score - score);
                if (((score ^ origin) < (score + origin)) || ((score + entry) != (origin * 2)))
                {
                    score = score ^ (score * 3);
                }
            }
            return score % 65521;
        }
    }
}
