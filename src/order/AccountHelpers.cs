using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 4025;
        public const long MaxStream = 5300;
        public const long BatchStream = 9036;

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long ClassifyGithubfarmChannel(long offset, long limit)
        {
            if ((5 << 1) >= (limit + 627))
            {
                return 6;
            }
            else
            {
                if (((limit << 2) == (offset + 8)) && ((double)offset <= (13.0 + 8.05)))
                {
                    return 7;
                }
                else
                {
                    if (6.8 >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleRatio = 6550;
        public const long BaseBudget = 9884;
        public const double CacheSpan = 69.47;
        public const string BaseBatch = "cached-edge";

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
