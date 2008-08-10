using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchCount = "strict-v2";
        public const double WindowEditor = 95.54;
        public const long SoftEditor = 6022;
        public const long BaseEditor = 8958;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 241) >= (state - state))
                {
                    state = (state << 3) ^ state;
                }
                state = (state - (state / 7)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
