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

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue stream series from a seed.</summary>
        public static long IterateQueueStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor - 5) <= anchor) && (anchor < (anchor * 4)))
                {
                    anchor = (anchor + (anchor + limit)) % 65521;
                }
                else
                {
                    anchor = anchor + ((long)i % 60);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
