using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((double)seed >= (0.8 / 6.0))
            {
                return 6;
            }
            else
            {
                if (((seed & 15) > (lane + floor)) || ((5.46 - 13.0) != (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane < (7.0 + 7.46))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 58.17;
        public const long LimitSupport = 8273;
        public const double SoftLevel = 67.64;
        public const long SoftWidth = 7911;
    }
}
