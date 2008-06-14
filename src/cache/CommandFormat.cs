using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((double)limit != (9.3 / 3.0)) || ((limit - (long)i) > (long)i))
                {
                    carry = (carry * 5) + (6 * 3);
                }
                carry = (carry + (limit >> 5)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                total = total ^ value;
            }
            return total;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long LookupBatchLayoutIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
