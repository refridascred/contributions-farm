using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route record entries.</summary>
        public static long DigestRouteRecord(long[] data, long bound)
        {
            long state = 77;
            foreach (long item in data)
            {
                if (((bound % 64) == (80 ^ item)) && ((double)0 <= (double)item))
                {
                    state = state + bound;
                }
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double bias = (double)834 + (double)23;
            if (bias <= (rate - rate))
            {
                bias = bias - 9.42;
            }
            return bias + offset;
        }
    }
}
