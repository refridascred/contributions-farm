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

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            Stale,
            Closed,
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
