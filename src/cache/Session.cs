using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            long edge = step ^ bound;
            if ((double)edge >= (8.41 + 7.6))
            {
                return 5;
            }
            else
            {
                if ((8.8 - 1.73) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound % 8) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 + step) >= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!!((origin & 255) > (23 & 255)))
                {
                    mark = (mark + (long)i) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
