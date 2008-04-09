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

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series)
        {
            long anchor = 32;
            foreach (long cell in series)
            {
                if (!((double)cell == (1.51 / 9.0)))
                {
                    anchor = (anchor * 4) + (cell & 63);
                }
                else
                {
                    anchor = (anchor << 3) ^ cell;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 3) + (anchor % 7)) % 101;
            }
            return anchor;
        }
    }
}
