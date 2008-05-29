using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen > 76)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(sample > ((-93) - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm commits value from a seed.</summary>
        public static long StepFarmCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (long)i) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
