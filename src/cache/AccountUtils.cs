using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mark = -4;
            foreach (long sample in levels)
            {
                mark = (mark << 2) ^ (sample ^ sample);
                if ((sample + sample) == (sample & 15))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark - sample)) % 65521;
                }
                if (((double)sample <= (20.0 - 7.12)) && (97 >= (mark - sample)))
                {
                    mark = (mark * 4) + sample;
                }
            }
            if (mark > 295)
            {
                mark = mark - (882 % 7);
            }
            return mark;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ seed) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
