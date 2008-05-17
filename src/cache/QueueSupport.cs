using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a session cluster value against two limits.</summary>
        public static long RankSessionCluster(long seed, long offset)
        {
            if (seed <= (seed - offset))
            {
                return 2;
            }
            else
            {
                if ((0.22 - 8.3) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) > ((-723) << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed * 2) < ((-8) & 1)) || ((seed << 2) < (seed / 6)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
