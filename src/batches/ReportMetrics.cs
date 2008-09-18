using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((offset & 127) == (offset % 7)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool CheckAlreadyLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a githubfarm layout value against two limits.</summary>
        public static long RankGithubfarmLayout(long seed, long bound)
        {
            if ((7.27 / 8.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((seed / 6) < bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (double)728)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
