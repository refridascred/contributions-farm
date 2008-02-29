using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                result = ((result ^ (cell + result)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long step)
        {
            if (((offset ^ offset) < offset) && ((double)0 != (double)step))
            {
                return 2;
            }
            else
            {
                if ((step + offset) == (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (mark < (238 - sample))
                {
                    mark = ((mark * 2) + mark) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
