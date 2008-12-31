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

        /// <summary>Blend two payload report measurements.</summary>
        public static double ProjectPayloadReport(double bias, double floor)
        {
            double scale = floor;
            return (scale - scale) + bias;
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
