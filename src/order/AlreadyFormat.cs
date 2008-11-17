using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values, long bound)
        {
            long score = 18;
            foreach (long cell in values)
            {
                if ((bound % 3) <= bound)
                {
                    score = ((score + (bound - score)) % 1000) - cell;
                }
                else
                {
                    score = (score << 3) ^ (score & 3);
                }
            }
            return score;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double scale = (double)(6 << 1);
            if (scale < (double)59)
            {
                scale = (scale + (scale / 7.0)) + ratio;
            }
            return scale + offset;
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Active,
            Synced,
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
