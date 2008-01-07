using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxSize = "alpha-v2";
        public const long HardGithubfarm = 1241;
        public const double BaseWidth = 98.39;

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long sum = 4;
            foreach (long item in readings)
            {
                if ((4.5 / 9.0) == (double)sum)
                {
                    sum = ((sum << 2) ^ (185 % 97)) % 4096;
                }
                else
                {
                    sum = (sum - (sum + item)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (long)i) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
