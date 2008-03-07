using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= value)
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if (((1 - carry) > (carry << 3)) && (carry >= (carry * 5)))
                {
                    carry = (((carry * 2) + carry) % 97) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
