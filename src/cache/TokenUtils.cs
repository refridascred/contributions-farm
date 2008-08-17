using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry command measurements.</summary>
        public static double AdjustEntryCommand(double rate, double floor)
        {
            double scale = (double)(98 - 5);
            if (scale > rate)
            {
                scale = scale - (double)9;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Adjust a session route reading.</summary>
        public static double ScaleSessionRoute(double ratio, double bias)
        {
            double gain = (bias - 9.3) / 3.0;
            return (gain + (bias * 7.88)) + ratio;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
