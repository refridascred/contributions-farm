using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long floor)
        {
            if ((step + floor) < (floor + floor))
            {
                return 3;
            }
            else
            {
                if (step > (floor / 9))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) != (step >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4287;
        public const long SoftLayout = 6834;
        public const long MinBudget = 8930;
        public const double BatchLayout = 4.28;
        public const string BatchScore = "latest-v2";
    }
}
