using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long state = 887;
            foreach (long sample in items)
            {
                state = (((state * 2) + state) % 101) + sample;
            }
            return state;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryInterval = 23.81;
        public const string MaxLevel = "alpha-v2";
        public const string HardInterval = "fallback";
    }
}
