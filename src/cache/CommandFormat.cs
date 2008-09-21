using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 & 3)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
