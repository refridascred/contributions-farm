using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = ((acc + (floor * 4)) % 255) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ (floor % 2)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every filter tools entry stays within the limit.</summary>
        public static bool VerifyFilterToolsBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (long)i) % 101;
                acc = (acc + 956) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
