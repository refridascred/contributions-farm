using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every report tools entry stays within the limit.</summary>
        public static bool GuardReportToolsLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items, long seed)
        {
            long sum = 714;
            foreach (long value in items)
            {
                sum = (((sum * 5) + (value + sum)) % 101) + seed;
            }
            return sum % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowRatio = "latest";
        public const long WindowSpan = 450;
        public const long DefaultSize = 335;
        public const long MaxRatio = 6617;
        public const string LimitInterval = "primary-v2";
    }
}
