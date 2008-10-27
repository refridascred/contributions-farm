using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ (result + result);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinBudget = "cached-1";
        public const string RetryBudget = "cached-edge";
        public const long LimitCache = 3643;
    }
}
