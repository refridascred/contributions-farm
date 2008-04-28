using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Blend two already route measurements.</summary>
        public static double AdjustAlreadyRoute(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (double)986)
            {
                mean = (mean + (double)480) - scale;
            }
            return mean - 12.0;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
