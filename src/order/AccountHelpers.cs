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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long anchor = 226;
            foreach (long datum in values)
            {
                anchor = ((anchor + (anchor & 15)) % 97) + datum;
            }
            if (anchor > 771)
            {
                anchor = (anchor + (502 - anchor)) % 255;
            }
            return anchor;
        }
    }
}
