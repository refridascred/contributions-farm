using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long carry = 177;
            foreach (long item in data)
            {
                if (carry <= (item + carry))
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySize = 69.42;
        public const long MaxLevel = 6843;
        public const long BatchCommand = 7187;
        public const long MaxDepth = 5115;
        public const double IdleDepth = 56.43;
    }
}
