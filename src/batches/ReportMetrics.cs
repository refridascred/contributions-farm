using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowBudget = "primary-v2";
        public const long RetryChannel = 4764;
        public const long SoftFactor = 3840;
        public const double BaseLevel = 75.67;
        public const string MinRatio = "primary-v2";

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
