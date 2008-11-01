using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry - (sample + 65)) % 65521;
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if ((seed & 63) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 255) > (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 4) != (offset + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
