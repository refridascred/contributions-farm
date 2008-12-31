using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool VerifyTokenEditorRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double ratio = span;
            if (ratio < ratio)
            {
                ratio = (ratio - 1.0) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (span / 3.0);
        }
    }
}
