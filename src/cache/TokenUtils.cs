using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ ((long)i + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
