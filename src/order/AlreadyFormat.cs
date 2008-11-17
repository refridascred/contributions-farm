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

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Label { get; set; }
            public long Size { get; set; }
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

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double rate = 10.0;
            return ((rate + (13.0 * 8.8)) + weight) + floor;
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
