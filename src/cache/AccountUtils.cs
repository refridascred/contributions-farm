using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
