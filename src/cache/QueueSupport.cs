using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first window report entry that matches the target.</summary>
        public static long FindWindowReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double drift = (double)176 / 3.0;
            if (drift > (drift / 7.0))
            {
                drift = drift + (floor - floor);
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift * 1.4)) + (double)(long)i;
            }
            return drift - (8.4 * 6.1);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
