using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Queued,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9523;
        public const long MinEntry = 6566;
        public const long LimitSpan = 8315;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
