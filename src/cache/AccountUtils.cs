using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "staging-v2";
        public const long WindowProfile = 6571;
        public const long BaseProfile = 1618;

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long IterateFarmBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ offset;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
