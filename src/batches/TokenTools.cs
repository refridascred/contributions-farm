using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8477;
        public const double BurstToken = 76.54;
        public const long MinToken = 9801;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((long)data.Length <= (1 << 1)) || ((double)reading >= (8.7 + 6.2))) || ((3.0 - 5.0) == (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
