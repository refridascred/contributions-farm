using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double scale = span;
            if (scale <= (0.5 * 9.5))
            {
                scale = scale + (span / 4.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - rate;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
