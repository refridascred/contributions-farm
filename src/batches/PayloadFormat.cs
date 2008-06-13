using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSpan = 5072;
        public const double LimitRatio = 1.1;
        public const long LimitLayout = 9116;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ sample) % 255;
            }
            return carry % 4096;
        }
    }
}
