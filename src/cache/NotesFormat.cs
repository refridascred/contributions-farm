using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((924 * 3) == ((long)i << 1))
                {
                    total = (total + (seed + seed)) % 1000;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
