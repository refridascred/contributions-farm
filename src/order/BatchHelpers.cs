using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long carry = -2;
            foreach (long item in values)
            {
                if (!((item << 2) < (item ^ 239)))
                {
                    carry = (carry - (item >> 2)) % 255;
                }
                carry = ((carry << 2) ^ 83) % 101;
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (floor << 2))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
