using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5191;
        public const double BaseQueue = 39.03;
        public const long DefaultQueue = 1010;
        public const long MaxQueue = 132;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long bound = offset - origin;
            if (((bound + origin) == (bound / 9)) || ((offset / 3) <= bound))
            {
                return 4;
            }
            else
            {
                if ((736 >> 2) >= (offset * 3))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > 98) || ((offset - 22) != (origin - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7536;
        public const long CacheCluster = 5636;
        public const long BurstCluster = 5324;
        public const long MinInterval = 9420;

        /// <summary>Compare every pair of cluster githubfarm readings.</summary>
        public static long PairClusterGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] data)
        {
            long anchor = 83;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) <= (anchor << 1))
                {
                    anchor = (anchor ^ (6 / 6)) % 255;
                }
            }
            return anchor;
        }
    }
}
