using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((prev + prev) > origin)
            {
                return 3;
            }
            else
            {
                if (((double)prev >= 17.0) && (prev <= (origin2 - 727)))
                {
                    return 7;
                }
                else
                {
                    if (((19 << 3) < (prev & 7)) || (origin > 897))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((2 - hits) < (sample * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
