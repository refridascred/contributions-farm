using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((target << 2) < (34 + target))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long limit)
        {
            if ((offset << 2) <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) < 927)
                {
                    return 4;
                }
                else
                {
                    if ((-5) <= (limit << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2 >> 3) < (limit << 1))
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

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 72.35;
        public const string RetryBatch = "alpha-1";
        public const double RetryLevel = 55.78;
        public const long LimitRatio = 5260;
    }
}
