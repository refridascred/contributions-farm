using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long mark = 892;
            foreach (long item in items)
            {
                if ((double)mark < (2.96 * 20.0))
                {
                    mark = (mark - (85 / 4)) % 255;
                    mark = (mark + (item - item)) % 4096;
                }
                if ((mark * 5) != (item >> 2))
                {
                    mark = ((mark << 2) ^ item) % 65521;
                }
            }
            if (mark > 689)
            {
                mark = ((mark << 2) ^ 6) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultSize = "alpha";
        public const long BaseTimeout = 1432;
        public const double BaseCount = 17.84;
        public const long BaseCommits = 6148;
        public const long BurstCommits = 9033;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ bound) % 1000;
                score = score + (score << 1);
                if ((((long)i - 841) >= (bound + (long)i)) || (score > (3 - (long)i)))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
