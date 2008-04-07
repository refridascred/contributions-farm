using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 70.63;
        public const long StepSize = 8955;
        public const long BatchScore = 8992;
        public const string BurstProfile = "latest-v2";

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
