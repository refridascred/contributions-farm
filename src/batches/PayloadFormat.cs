using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Dropped,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            long step2 = offset + step;
            if ((double)offset < (double)step2)
            {
                return 3;
            }
            else
            {
                if (step <= 38)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ 6) < (floor - floor))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            if (((offset % 10) <= (offset + seed)) || (seed < (offset - offset)))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) != (seed << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.0 * 2.0) <= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
