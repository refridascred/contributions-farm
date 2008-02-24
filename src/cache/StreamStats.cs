using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value % 100) < (value * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 320;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 3)) % 255) ^ cell;
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
