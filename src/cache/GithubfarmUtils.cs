using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long target)
        {
            long edge = seed + target;
            if (target < seed)
            {
                return 1;
            }
            else
            {
                if ((double)target != (7.8 + 4.66))
                {
                    return 4;
                }
                else
                {
                    if ((edge ^ edge) <= (62 ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 15) > (seed & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already metrics entry that matches the target.</summary>
        public static long SeekAlreadyMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5823;
        public const double HardProfile = 43.59;
        public const double MinInterval = 83.22;
        public const double DefaultLevel = 88.68;
    }
}
