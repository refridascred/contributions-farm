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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double gain2 = (double)80 + (18.0 - 7.5);
            if (gain2 >= (floor / 5.0))
            {
                gain2 = gain2 + (1.0 * 18.0);
            }
            return gain2 - gain;
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
