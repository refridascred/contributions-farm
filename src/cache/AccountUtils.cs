using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every stats editor entry stays within the limit.</summary>
        public static bool VerifyStatsEditorBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already farm measurements.</summary>
        public static double ScaleAlreadyFarm(double gain, double floor)
        {
            double load = 2.39;
            return ((load - 1.8) + gain) + floor;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
