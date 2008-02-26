using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every support tools entry stays within the limit.</summary>
        public static bool ValidateSupportToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
