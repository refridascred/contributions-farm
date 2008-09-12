using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a profile entry counter forward.</summary>
        public static long DeriveProfileEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = carry + (carry >> 1);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
