using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = (scale - floor) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.9 / 2.0)) + (double)(long)i;
            }
            return scale + (double)61;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double ratio2 = ratio * 3.1;
            if (ratio2 >= 3.26)
            {
                ratio2 = (ratio2 + (double)205) - offset;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
