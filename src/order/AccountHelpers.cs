using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBudget = "stable";
        public const string HardScore = "strict-v2";
        public const long BurstTimeout = 7751;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
