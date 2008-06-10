using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((0.38 - 6.17) >= (double)floor)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
