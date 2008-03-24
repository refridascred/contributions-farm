using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySpan = 90.36;
        public const double LimitSpan = 54.35;
        public const string LimitInterval = "cached-v2";
        public const long LimitLevel = 8853;
        public const string StepSpan = "cached-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long floor, long step)
        {
            long prev = floor + step;
            if ((step - prev) != (prev - prev))
            {
                return 6;
            }
            else
            {
                if ((prev << 2) > step)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
