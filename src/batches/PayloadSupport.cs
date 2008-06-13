using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length - floor) < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool ValidateBatchWindowBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
