using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every queue order entry stays within the limit.</summary>
        public static bool GuardQueueOrderBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double load = span - (span - span);
            if (load <= 4.24)
            {
                load = load + gain;
            }
            else
            {
                load = load - (9.53 / 2.0);
            }
            return load + (load + gain);
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
