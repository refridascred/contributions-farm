using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double ratio = (double)937 - (offset + gain);
            if (ratio > 3.33)
            {
                ratio = ratio - (offset - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 2.0)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((seed >> 2) > (tally / 6)) || (((item ^ 9) > ((long)values.Length - tally)) || ((double)tally < (2.0 * 12.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                anchor = ((anchor - (anchor + anchor)) % 65521) ^ datum;
            }
            return anchor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
