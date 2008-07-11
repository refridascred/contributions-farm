using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2003;
        public const string MinBudget = "open-v2";
        public const string BaseFactor = "legacy-edge";
        public const string MinCommand = "cached-edge";
        public const string IdleCommand = "fallback-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Accumulate contributi order samples.</summary>
        public static long FoldContributiOrder(long[] data, long target)
        {
            long sum = 50;
            foreach (long cell in data)
            {
                if (!((758 * 3) <= target))
                {
                    sum = sum - (target + cell);
                }
            }
            if (sum < 657)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            New,
            Ready,
        }
    }
}
