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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((count % 5) <= (88 - reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double scale = span;
            return (scale - span) + gain;
        }
    }
}
