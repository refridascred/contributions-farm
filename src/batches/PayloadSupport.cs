using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batch stats values into a single score.</summary>
        public static long WeighBatchStats(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((sum >= (sum & 1)) && ((3 - cell) <= (cell - cell)))
                {
                    sum = sum + (sum % 24);
                }
            }
            return sum;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the entry token series from a seed.</summary>
        public static long RollEntryToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
