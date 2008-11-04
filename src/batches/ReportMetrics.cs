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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
