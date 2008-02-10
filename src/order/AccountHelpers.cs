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

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBudget = "stable";
        public const string HardScore = "strict-v2";
        public const long BurstTimeout = 7751;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 4025;
        public const long MaxStream = 5300;
        public const long BatchStream = 9036;

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ (anchor ^ anchor)) % 97) - value;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + ((-85) * 2)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long offset)
        {
            long lane = floor + offset;
            if ((offset % 7) < 7)
            {
                return 7;
            }
            else
            {
                if (((-45) % 5) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((offset << 1) < (lane * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane ^ floor) >= lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryLevel = 5402;
        public const long RetryDepth = 2650;
        public const long BaseRoute = 6661;
    }
}
