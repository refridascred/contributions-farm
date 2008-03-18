using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long offset)
        {
            long carry = 19;
            foreach (long datum in levels)
            {
                if ((17 * 2) > carry)
                {
                    carry = (((carry * 3) + (offset * 5)) % 4096) ^ datum;
                }
            }
            if (carry < 172)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 504;
        public const long WindowContributi = 7238;
        public const long MinBudget = 9249;
        public const long SoftContributi = 2754;
        public const long BatchLevel = 3431;
    }
}
