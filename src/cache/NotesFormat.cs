using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
