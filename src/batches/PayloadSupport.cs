using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double bias = 0.3;
            if (bias >= (span * 8.04))
            {
                bias = bias + (double)4;
            }
            else
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (ratio + ratio)) - (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
