using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 582;
        public const long IdleSession = 9633;
        public const string BaseSession = "cached";
        public const string HardFactor = "strict";
        public const long DefaultSession = 34;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ bound;
                if (carry >= (bound - carry))
                {
                    carry = (carry + (968 << 2)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (5.0 * 8.5))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
