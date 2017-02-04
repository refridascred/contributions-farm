using System;

namespace Common.Utilities
{
    /// <summary>Payload tools helpers.</summary>
    public static class PayloadTools
    {
        /// <summary>Clamp a stream value to a valid range.</summary>
        public static double ClampStream(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Express a session count as a percentage.</summary>
        public static double SessionPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
