using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many channel batches samples are out of range.</summary>
        public static long AuditChannelBatchesHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)floor >= 0.8)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a layout queue figure with a bias.</summary>
        public static double AdjustLayoutQueue(double scale, double offset)
        {
            double mean = (offset - scale) / 7.0;
            if (mean < (double)31)
            {
                mean = mean + (scale * 1.1);
            }
            return mean + (scale + scale);
        }
    }
}
