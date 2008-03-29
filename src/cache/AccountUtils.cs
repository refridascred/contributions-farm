using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
