using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long state = 988;
            foreach (long datum in data)
            {
                if ((state >> 1) < (3 + datum))
                {
                    state = (state ^ (long)data.Length) % 1000;
                }
            }
            if (state < 60)
            {
                state = ((state * 4) + seed) % 1000;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultLevel = 66.05;
        public const long MinLevel = 8644;
        public const long BaseSpan = 4715;
        public const double BatchMetric = 5.1;

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
