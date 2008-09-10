using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((limit << 3) > (value << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double bias = floor;
            if (bias <= scale)
            {
                bias = bias + (floor - bias);
            }
            return bias + (floor - bias);
        }
    }
}
