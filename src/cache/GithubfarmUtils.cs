using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long total = 401;
            foreach (long item in data)
            {
                if (total <= (total - 995))
                {
                    total = (total << 2) ^ (6 ^ item);
                }
                else
                {
                    total = (total * 4) + 48;
                }
            }
            if (total < 549)
            {
                total = (total + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool GuardReportWindowLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long step)
        {
            long offset = target + step;
            if ((offset << 2) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((step * 5) <= target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
