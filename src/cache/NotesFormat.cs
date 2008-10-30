using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "staging-edge";
        public const string RetrySpan = "cached";
        public const long BurstSpan = 3623;
        public const long SoftSpan = 9985;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 5) + step;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Stale,
        }
    }
}
