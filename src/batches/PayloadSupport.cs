using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (((floor + 95) != (floor ^ seed)) || ((seed - seed) < floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long AuditBufferOrderHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((bound ^ count) != ((long)samples.Length & 3)) && ((double)bound <= (4.3 - 0.3)))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
