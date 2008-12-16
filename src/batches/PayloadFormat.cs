using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample % 8) <= (floor + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long seed)
        {
            long step = limit + seed;
            if ((double)seed == (double)limit)
            {
                return 1;
            }
            else
            {
                if (748 <= (step << 2))
                {
                    return 5;
                }
                else
                {
                    if ((8.13 / 3.0) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (6 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
