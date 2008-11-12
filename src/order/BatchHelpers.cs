using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i + offset) != (carry ^ offset)) || ((carry + offset) != ((long)i - (long)i)))
                {
                    carry = (carry + offset) % 101;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
