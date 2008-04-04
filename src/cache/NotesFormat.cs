using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long ScoreChecksCache(long[] data, long bound)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (bound * 2)) % 255;
                total = ((total * 4) + item) % 4096;
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)limit != (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count token entry pairs that satisfy a relation.</summary>
        public static long MatchTokenEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
