using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first stats editor entry that matches the target.</summary>
        public static long LookupStatsEditorIndex(long[] readings, long floor)
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
