using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool ValidateFarmAccountLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((seed - seed) >= ((-951) ^ seed)) || ((seed >> 1) > (tally & 1)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
