using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long CountStatsContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(460 >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + matches) != (matches ^ sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)offset == (6.25 * 19.0)))
                {
                    sum = (sum ^ (sum - sum)) % 1000;
                    sum = ((sum * 3) + offset) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
