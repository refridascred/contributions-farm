using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Synced,
            New,
            Active,
        }

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long MeasureCacheMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item >= (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
