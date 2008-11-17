using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long state = 0;
            foreach (long datum in series)
            {
                state = state ^ (state + datum);
            }
            if (state > 3)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((20.0 - 14.0) <= (double)datum)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the queue account entries that pass the check.</summary>
        public static long TallyQueueAccountOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((83 - seed) == (seed - seen))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long CountChecksEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading - hits) >= reading) || (((hits + hits) < (reading + hits)) || ((7.2 / 6.0) == (double)reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
