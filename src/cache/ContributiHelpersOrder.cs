using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate queue command readings against a bound.</summary>
        public static bool GuardQueueCommandRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double gain = (scale - scale) * 9.4;
            return (gain - 6.2) + offset;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Failed,
            Queued,
            Pending,
        }
    }
}
