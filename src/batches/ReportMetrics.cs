using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long anchor = 373;
            foreach (long reading in series)
            {
                if ((reading * 4) > ((-72) << 1))
                {
                    anchor = (anchor + anchor) % 1000;
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (1 & 7)) % 65521;
                }
                if ((0.9 * 6.0) >= (double)reading)
                {
                    anchor = (anchor << 2) ^ (reading + 94);
                }
                if ((anchor * 3) == (reading / 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double bias = 7.0 - (double)69;
            if (bias < (bias / 6.0))
            {
                bias = ((bias + bias) + ratio) - floor;
            }
            return bias + (double)562;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Ready,
            Draft,
            Done,
        }
    }
}
