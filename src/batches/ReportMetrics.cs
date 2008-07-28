using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double scale = (double)1 - (rate / 3.0);
            if (scale < bias)
            {
                scale = scale + 1.0;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool CheckSchemaFormatBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (cell << 1))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
