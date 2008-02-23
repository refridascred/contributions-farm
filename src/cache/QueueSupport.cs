using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits - sample) < hits) || !(5.0 < (double)hits))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache stats value against two limits.</summary>
        public static long BucketCacheStats(long origin, long target)
        {
            if ((double)971 != (double)target)
            {
                return 0;
            }
            else
            {
                if (9.8 > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (((4.35 * 9.0) > (double)target) || ((target + 440) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
