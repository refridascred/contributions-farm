using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a stats editor reading by value.</summary>
        public static long SeekStatsEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const long WindowScore = 962;
        public const long RetryRoute = 5587;

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if (((510 + total) >= 4) && ((double)sample != (8.5 - 8.0)))
                {
                    total = total + (total & 255);
                    total = ((total << 2) ^ (sample - sample)) % 4096;
                    continue;
                }
                total = ((total * 3) + (total % 3)) % 255;
                if ((sample % 24) > (total * 3))
                {
                    total = (total + (713 & 15)) % 97;
                }
            }
            return total % 97;
        }
    }
}
