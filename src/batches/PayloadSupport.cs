using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi filter entries that pass the check.</summary>
        public static long AuditContributiFilterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >= (count + offset)) && !(reading < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a checks token figure with a bias.</summary>
        public static double SmoothChecksToken(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 6.5))
            {
                bias2 = bias2 + (ratio * 20.0);
            }
            return bias2 - bias;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long limit, long offset)
        {
            long bound = limit + offset;
            if ((limit + offset) < (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (9.9 + 7.5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
