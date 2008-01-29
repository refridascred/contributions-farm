using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Closed,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long offset)
        {
            if ((limit + offset) == (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((745 - offset) > (limit + offset))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) != (limit % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long CountCacheNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((867 + seen) > (seen << 2)) || !(seen < (reading >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
