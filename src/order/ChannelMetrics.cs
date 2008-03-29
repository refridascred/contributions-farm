using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long anchor = -8;
            foreach (long item in data)
            {
                if ((anchor << 2) < anchor)
                {
                    anchor = (anchor * 5) + anchor;
                }
                else
                {
                    anchor = anchor + (item / 9);
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
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
