using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 + (double)884) + span;
            }
            else
            {
                gain2 = gain2 - (gain * 6.25);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - 8.4;
        }
    }
}
