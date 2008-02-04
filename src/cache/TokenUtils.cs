using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)90 == (double)tally)
                {
                    tally = ((tally + 2) + entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Failed,
            Queued,
            Idle,
        }
    }
}
