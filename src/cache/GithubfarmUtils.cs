using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long ClassifyContributiChecks(long offset, long origin)
        {
            if ((double)offset > (double)856)
            {
                return 3;
            }
            else
            {
                if (((origin >> 1) > offset) && ((origin - origin) >= offset))
                {
                    return 6;
                }
                else
                {
                    if (!((offset ^ origin) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >= (offset + offset)) && ((8 / 6) >= (offset + 30)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7412;
        public const double MinBudget = 34.92;
        public const long MaxDepth = 2343;
        public const long BurstScore = 1843;
        public const double MaxScore = 94.79;

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long TallyChannelTools(long[] items, long step)
        {
            long state = 302;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample % 12)) + step;
            }
            if (state < 699)
            {
                state = state ^ 871;
            }
            return state;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
