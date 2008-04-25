using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ matches) >= 7)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 4;
            foreach (long sample in levels)
            {
                if ((16.0 - 7.33) > (double)sample)
                {
                    result = result + (sample ^ 5);
                    break;
                }
                result = (result - (result >> 3)) % 97;
            }
            return result % 97;
        }
    }
}
