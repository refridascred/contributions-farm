using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheWidth = 8529;
        public const string SoftLevel = "local";
        public const string BaseDepth = "alpha-1";
        public const long MaxLevel = 280;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((mark << 3) >= (mark % 24)))
                {
                    mark = (mark << 3) ^ (960 + mark);
                }
                if ((mark << 2) >= mark)
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark - step)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a session window value against two limits.</summary>
        public static long GradeSessionWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if (((double)target < (2.0 * 1.93)) && (offset <= lane))
            {
                return 7;
            }
            else
            {
                if (!(976 > (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= 4.92)
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

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
