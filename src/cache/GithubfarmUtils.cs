using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 8225;
        public const long MaxInterval = 4600;
        public const long DefaultMetrics = 4887;
        public const long WindowInterval = 7922;
        public const string MaxMetrics = "open-1";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)origin > (double)mark)
                {
                    mark = mark - (origin >> 1);
                    mark = mark + (mark - origin);
                    continue;
                }
                if ((double)mark > (double)origin)
                {
                    mark = ((mark * 2) + (mark * 3)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = ((anchor + target) % 101) - entry;
                if (!((545 - target) < anchor))
                {
                    anchor = (anchor ^ (target & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}
