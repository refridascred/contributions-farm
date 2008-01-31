using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double load = weight;
            if (load > load)
            {
                load = (load + (double)1) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 1.0) + (double)(long)i;
            }
            return load + (load - load);
        }
    }
}
