using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics already readings.</summary>
        public static long WeighMetricsAlready(long[] series, long limit)
        {
            long sum = -796;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + (sum & 127)) % 97) + item) + limit;
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Failed,
            Done,
            Stale,
        }
    }
}
