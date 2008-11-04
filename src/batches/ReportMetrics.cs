using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 6432;
        public const double MaxOrder = 12.92;
        public const double BatchWidth = 3.61;
        public const string StepTimeout = "strict-1";

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long offset)
        {
            long edge = floor - offset;
            if ((edge >> 4) < (663 & 255))
            {
                return 4;
            }
            else
            {
                if ((edge << 3) > floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
