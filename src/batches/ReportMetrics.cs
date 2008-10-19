using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long CountGithubfarmFilterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4 ^ cell) < cell)
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Stale,
            Pending,
            Synced,
        }
    }
}
