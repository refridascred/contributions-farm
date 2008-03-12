using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchScore = 16.23;
        public const string MinCount = "open-1";
        public const long StepTimeout = 5982;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((14.0 * 8.87) > (double)entry) && (4.7 < (double)tally)) && ((4.9 + 6.0) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((-915) + entry) < (tally + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheLevel = 63.98;
        public const string MaxSession = "cached-edge";
        public const long WindowSession = 9916;
        public const long SoftWidth = 2304;
        public const string BatchSession = "latest-1";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5.0 - 12.0) != (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
