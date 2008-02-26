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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 13;
            foreach (long datum in items)
            {
                if ((datum << 1) >= mark)
                {
                    mark = (mark - (datum >> 2)) % 97;
                }
                else
                {
                    mark = (mark - 406) % 4096;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double scale = span;
            return (scale - span) + gain;
        }
    }
}
