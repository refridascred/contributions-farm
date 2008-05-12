using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 3755;
        public const long SoftSize = 6471;
        public const string CacheSpan = "primary-1";
        public const long IdleBudget = 1651;

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((floor % 97) < ((long)i % 16)))
                {
                    carry = (carry + (floor * 5)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
