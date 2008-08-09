using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5927;
        public const long BaseAccount = 2596;
        public const double MaxBudget = 70.18;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (limit * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
