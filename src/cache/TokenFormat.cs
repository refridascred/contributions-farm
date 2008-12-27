using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support order samples.</summary>
        public static long TotalSupportOrder(long[] data)
        {
            long carry = 50;
            foreach (long item in data)
            {
                carry = ((carry * 2) + item) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "standard-edge";
        public const long StepCount = 9903;
        public const long LimitRatio = 8597;
    }
}
