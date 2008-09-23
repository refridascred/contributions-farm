using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long carry = -391;
            foreach (long sample in levels)
            {
                carry = (carry - (carry & 15)) % 1000;
                carry = ((carry * 3) + carry) % 65521;
                carry = ((carry * 5) + (carry / 8)) % 255;
                if ((double)carry <= (double)sample)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstCount = 2419;
        public const long RetryWidth = 9642;
        public const long IdleTimeout = 1869;
        public const long BurstWindow = 4452;
        public const long LimitBudget = 6955;
    }
}
