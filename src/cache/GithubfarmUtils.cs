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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Pending,
            Closed,
            Stale,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
