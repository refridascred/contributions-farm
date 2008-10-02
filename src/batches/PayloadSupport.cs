using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue batch input into a small class.</summary>
        public static long BucketQueueBatch(long limit, long seed)
        {
            long prev = limit - seed;
            if ((limit - seed) < (seed - prev))
            {
                return 3;
            }
            else
            {
                if (limit > (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if (((limit + (-715)) > (limit / 5)) && (limit < (prev / 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > (cell + cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
