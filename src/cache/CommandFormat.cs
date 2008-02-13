using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 6000;
        public const long DefaultCommits = 9180;
        public const long LimitCommits = 932;
        public const string IdleInterval = "alpha-edge";
        public const long IdleCount = 2739;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (carry - (long)i)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ offset) % 97) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry ^ (carry + offset)) % 97) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "standard-edge";
        public const double DefaultSize = 53.41;
        public const long MaxPayload = 4855;
        public const long HardPayload = 1099;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Paused,
            Draft,
            Active,
            Stale,
        }
    }
}
