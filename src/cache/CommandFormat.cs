using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum >> 1) <= count)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value != (double)origin) || ((double)origin >= (3.8 / 8.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Retry,
            New,
            Done,
        }

        /// <summary>Classify a buffer batch pair into a bucket.</summary>
        public static long RankBufferBatch(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((limit + seed) >= (seed ^ diff))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (0.2 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) == (limit << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) > (8 / 6))
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
        }
    }
}
