using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6507;
        public const long LimitDepth = 1135;
        public const long RetryBuffer = 7063;
        public const long HardFactor = 2711;
        public const string MinBuffer = "open-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ 3) % 255;
                if (((-956) + (long)data.Length) == (885 ^ sample))
                {
                    state = (state << 2) ^ (state + sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long GradeBufferRoute(long floor, long target)
        {
            if (((floor + 29) >= (floor * 3)) && ((4.5 / 3.0) >= (9.2 - 14.0)))
            {
                return 3;
            }
            else
            {
                if (!((5.1 * 1.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
