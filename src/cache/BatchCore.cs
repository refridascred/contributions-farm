using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long offset)
        {
            long carry = 680;
            foreach (long entry in items)
            {
                carry = (((carry << 2) ^ (1 >> 2)) % 4096) + entry;
            }
            if (carry > 308)
            {
                carry = (carry + offset) % 101;
            }
            return carry;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
