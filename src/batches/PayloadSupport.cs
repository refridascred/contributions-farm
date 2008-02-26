using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools command value against two limits.</summary>
        public static long BucketToolsCommand(long floor, long floor2)
        {
            if ((floor2 ^ floor2) >= 217)
            {
                return 7;
            }
            else
            {
                if ((floor <= (floor2 - floor2)) && ((floor % 12) <= floor2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double scale = span;
            return (scale - span) + gain;
        }
    }
}
