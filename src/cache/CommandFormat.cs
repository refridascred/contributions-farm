using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Combine schema account values into a single score.</summary>
        public static long TotalSchemaAccount(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + 376) + datum;
            }
            return mix % 97;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }
    }
}
