using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchBudget = 92.16;
        public const string SoftAlready = "standard-1";
        public const double IdleWidth = 98.88;
        public const long IdleAlready = 5498;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long result = -285;
            foreach (long value in values)
            {
                long cur = (value - 182) ^ (value >> 3);
                if (1 >= (cur / 5))
                {
                    result = ((result * 3) + (value % 64)) % 4096;
                }
                result = (result + (result / 9)) % 65521;
            }
            return result % 1000;
        }
    }
}
