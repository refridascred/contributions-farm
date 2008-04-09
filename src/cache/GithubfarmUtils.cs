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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(2 > matches))
                {
                    matches = ((matches + 3) ^ reading) + offset;
                }
            }
            return matches;
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
