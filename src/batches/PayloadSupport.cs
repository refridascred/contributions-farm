using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = (floor - floor) - floor;
            return (scale - (double)82) + rate;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((double)cur < 7.1)
            {
                return 4;
            }
            else
            {
                if ((391 < (cur * 5)) && ((3.4 + 1.6) <= (3.3 / 2.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
