using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double load = (double)(3 + 73);
            if (load >= (double)6)
            {
                load = (load - floor) + bias;
            }
            else
            {
                load = load + (4.26 * 6.84);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (floor / 3.0)) - (double)(long)i;
            }
            return load - (19.0 / 6.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Check that every commits record entry stays within the limit.</summary>
        public static bool GuardCommitsRecordBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
