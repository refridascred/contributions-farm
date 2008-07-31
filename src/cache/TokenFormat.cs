using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long offset, long bound)
        {
            if (bound < (offset / 2))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
