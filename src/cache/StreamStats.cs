using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = weight + (double)(-695);
            if (rate >= (double)51)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - floor;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double bias = scale;
            if (bias < (offset + 3.0))
            {
                bias = bias - scale;
            }
            return bias - (offset + offset);
        }
    }
}
