using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 3800;
        public const long MaxInterval = 6939;
        public const double BaseInterval = 21.15;
        public const string WindowOrder = "standard-v2";

        /// <summary>Fold a list of report command readings.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long state = 304;
            foreach (long value in readings)
            {
                if ((value * 4) >= state)
                {
                    state = (state - state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Adjust a window farm reading.</summary>
        public static double ScaleWindowFarm(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > offset)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (ratio / 4.0);
        }
    }
}
