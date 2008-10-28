using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item < 9) && (((item << 2) >= matches) || ((matches % 5) <= (matches / 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 7523;
        public const long BaseBudget = 7866;
        public const double WindowBuffer = 1.04;
        public const long MinSize = 7290;
        public const long DefaultBuffer = 6997;

        /// <summary>Find the first githubfarm tools entry that matches the target.</summary>
        public static long LocateGithubfarmToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
