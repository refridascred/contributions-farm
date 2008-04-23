using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) != (762 + cell)) && (((matches ^ cell) > (matches + 390)) && ((cell * 3) < cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
