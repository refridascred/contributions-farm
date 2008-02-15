using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double gain = 4.9 + (scale + bias);
            return gain + (double)(-862);
        }
    }
}
