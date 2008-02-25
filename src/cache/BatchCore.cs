using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window queue entries that pass the check.</summary>
        public static long CountWindowQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((0.62 + 2.7) >= (double)hits) || (((long)series.Length ^ entry) < entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if (!((floor - floor) <= (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) > (seed + 6)) || ((seed + 9) > seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
