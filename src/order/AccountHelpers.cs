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

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double offset)
        {
            double scale = (double)36 + (double)7;
            if (scale > offset)
            {
                scale = scale - (scale * 8.2);
            }
            else
            {
                scale = scale + (double)419;
            }
            return scale - bias;
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
