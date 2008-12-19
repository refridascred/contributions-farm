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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Done,
            Stale,
            Active,
            Synced,
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
