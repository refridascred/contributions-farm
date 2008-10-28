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

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long origin)
        {
            long score = 7;
            foreach (long datum in items)
            {
                double scale = (double)(origin / 6);
                if ((double)origin >= scale)
                {
                    score = (score ^ (score ^ 516)) % 101;
                }
                if ((score - datum) <= origin)
                {
                    score = score ^ (origin - 9);
                }
            }
            return score % 97;
        }

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
