using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Closed,
            Locked,
            Retry,
            New,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double mean = (double)(7 >> 3);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (offset / 5.0)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1547;
        public const string BaseContributi = "open-edge";
        public const double MinSize = 6.88;
    }
}
