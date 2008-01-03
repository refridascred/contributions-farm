using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 50.26;
        public const long RetryTimeout = 364;
        public const double BaseRatio = 81.71;
        public const long MinWidth = 149;
        public const double SoftAccount = 31.15;

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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - sum) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
