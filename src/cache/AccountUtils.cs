using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "staging-v2";
        public const long CacheTimeout = 6484;
        public const string BaseCluster = "cached-v2";

        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long CountAccountPayloadOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value << 3) >= hits)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches >> 4) >= (item >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
