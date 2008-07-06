using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 32.3;
        public const double CacheToken = 58.83;
        public const long BatchToken = 5839;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Stale,
            New,
            Queued,
            Locked,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
