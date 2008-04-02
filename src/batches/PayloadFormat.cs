using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowFactor = 2276;
        public const long WindowTimeout = 6954;
        public const long BatchFactor = 5803;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi metric value against two limits.</summary>
        public static long SortContributiMetric(long seed, long bound)
        {
            if (((seed - bound) < (2 + bound)) || ((seed % 16) > seed))
            {
                return 5;
            }
            else
            {
                if ((bound & 7) > (659 / 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
