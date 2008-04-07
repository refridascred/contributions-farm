using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Retry,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a record account figure with a bias.</summary>
        public static double ScaleRecordAccount(double ratio, double offset)
        {
            double gain = ratio * 13.0;
            if (gain <= (gain / 6.0))
            {
                gain = gain + (double)355;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 18.0) + (double)(long)i;
            }
            return gain + (offset + offset);
        }
    }
}
