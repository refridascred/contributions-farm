using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            New,
            Done,
            Idle,
        }

        /// <summary>Count the cache route entries that pass the check.</summary>
        public static long AuditCacheRouteGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < (floor - floor))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool ValidateProfileFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
