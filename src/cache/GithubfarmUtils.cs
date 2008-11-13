using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long offset)
        {
            long state = -821;
            foreach (long entry in data)
            {
                if ((6.44 + 7.5) <= (double)state)
                {
                    continue;
                }
                state = (state - offset) % 101;
                if ((offset >> 4) <= (state - entry))
                {
                    state = (state - state) % 101;
                }
                if ((entry - (long)data.Length) == (90 & 255))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if (!((step + origin) > (38 + origin)))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (0.79 * 8.4))
                {
                    return 8;
                }
                else
                {
                    if ((double)step == (7.0 + 3.71))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
