using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultLevel = 7941;
        public const long RetryRatio = 2643;
        public const long WindowSize = 7225;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm cluster sample.</summary>
        public static long LocateGithubfarmClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long step = offset + target;
            if ((target + target) == (offset - target))
            {
                return 7;
            }
            else
            {
                if (target < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
