using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - bound) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (511 > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >> 5) > 514)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
