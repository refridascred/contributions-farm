using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (871 >= (matches << 2))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double load = (double)76;
            return ((load - 5.6) + ratio) + floor;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
