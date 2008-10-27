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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)result <= (8.0 + 5.8)))
                {
                    result = ((result * 4) + 3) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
