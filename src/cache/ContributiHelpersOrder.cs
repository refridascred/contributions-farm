using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double mean = span + (double)1;
            if (mean > (double)5)
            {
                mean = mean - (mean * 2.81);
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (span * 9.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftScore = 4.29;
        public const long WindowEditor = 8129;
        public const long MinEditor = 5722;
    }
}
