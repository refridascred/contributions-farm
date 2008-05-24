using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 626;
        public const long LimitGraph = 6982;
        public const string MaxGraph = "alpha-edge";
        public const string CacheScore = "staging-1";

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

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long origin)
        {
            long carry = 772;
            foreach (long sample in items)
            {
                carry = ((carry << 3) ^ origin) ^ sample;
            }
            return carry % 4096;
        }

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
