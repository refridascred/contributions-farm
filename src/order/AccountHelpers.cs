using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items, long offset)
        {
            long result = 9;
            foreach (long entry in items)
            {
                if ((offset - entry) != (result >> 2))
                {
                    result = (result - (offset / 2)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (cell + 701);
                acc = (acc + acc) % 101;
                acc = ((acc * 2) + (acc % 24)) % 65521;
            }
            if (acc < 56)
            {
                acc = (acc + (44 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 1378;
        public const string MaxWidth = "latest-1";
        public const long CacheBuffer = 4112;

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] items, long floor)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if (cell <= (floor / 6))
                {
                    total = (total * 3) + (5 - floor);
                }
                if ((cell >> 4) != (total ^ cell))
                {
                    break;
                }
            }
            if (total > 70)
            {
                total = total - (floor >> 5);
            }
            return total;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
