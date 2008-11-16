using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((6.0 / 9.0) < (double)target) && ((53 ^ hits) <= (hits - target)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((-626) + reading) >= (reading >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long bound)
        {
            if ((bound & 127) != (4 * 2))
            {
                return 2;
            }
            else
            {
                if (bound < (727 ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((2.96 - 1.51) < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
