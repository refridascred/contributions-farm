using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (sample >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits ^ hits) < (item - hits)) || ((double)674 <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a session filter sample.</summary>
        public static long FindSessionFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
