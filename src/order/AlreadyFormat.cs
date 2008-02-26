using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metric context input into a small class.</summary>
        public static long ClassifyMetricContext(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (((bound + (-7)) < (bound / 2)) && ((offset << 3) != (offset2 % 10)))
            {
                return 8;
            }
            else
            {
                if ((offset2 / 2) <= (offset << 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound + offset) <= offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseInterval = "primary-edge";
        public const string RetryFactor = "primary-edge";
        public const long IdleCommand = 6901;
        public const long RetryBudget = 2413;
        public const long WindowCommand = 1997;
    }
}
