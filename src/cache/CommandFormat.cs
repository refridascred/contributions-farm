using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if ((sample - carry) != (carry + sample))
                {
                    carry = ((carry ^ 20) % 101) + floor;
                }
            }
            if (carry > 71)
            {
                carry = ((carry * 5) + (carry & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TotalFilterChannel(long[] items, long limit)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((double)(long)items.Length > (8.9 / 9.0))
                {
                    state = ((state * 3) + (limit % 64)) + item;
                }
                else
                {
                    state = ((state << 3) ^ limit) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 22.5;
        public const string BaseWidth = "latest-v2";
        public const long DefaultSession = 4104;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Failed,
            Paused,
            Pending,
            Synced,
        }
    }
}
