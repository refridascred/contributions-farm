using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((target + target) >= (limit >> 3))
            {
                return 4;
            }
            else
            {
                if ((limit + target) > (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((5.0 + 3.0) < (double)target)
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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                if ((sample & 255) > sample)
                {
                    result = (result + ((-691) + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)limit >= (3.7 * 3.3)) && ((entry << 2) > 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
