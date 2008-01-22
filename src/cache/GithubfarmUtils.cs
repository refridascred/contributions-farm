using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            long gap = seed - target;
            if ((gap <= 8) && ((gap + target) > gap))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 10) <= (927 * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
