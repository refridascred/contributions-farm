using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long AuditCounterRouteOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)step > (double)item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool ValidateStatsProfileRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
