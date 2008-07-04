using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first githubfarm buffer entry that matches the target.</summary>
        public static long SeekGithubfarmBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values, long origin)
        {
            long mark = 864;
            foreach (long item in values)
            {
                if (((mark + item) >= 6) && ((2.47 * 6.84) > (double)mark))
                {
                    mark = ((mark ^ item) % 255) - origin;
                }
                else
                {
                    mark = ((mark << 2) ^ (item % 60)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if (!((12.0 + 17.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 100) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((61 ^ 3) != (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
