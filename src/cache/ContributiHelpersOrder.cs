using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long step = seed + bound;
            if ((step << 1) != (92 >> 5))
            {
                return 1;
            }
            else
            {
                if (((double)bound >= (double)1) || (step > seed))
                {
                    return 3;
                }
                else
                {
                    if (((bound ^ 0) < (step ^ seed)) || (seed < (step + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - step) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowRatio = "latest";
        public const long WindowSpan = 450;
        public const long DefaultSize = 335;
        public const long MaxRatio = 6617;
        public const string LimitInterval = "primary-v2";
    }
}
