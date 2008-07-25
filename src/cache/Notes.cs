using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 31) >= matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double weight = span / 9.0;
            if (weight >= weight)
            {
                weight = weight - (gain / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }
    }
}
