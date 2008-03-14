using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
