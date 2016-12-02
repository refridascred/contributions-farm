using System;

namespace Common.Utilities
{
    /// <summary>Report stats helpers.</summary>
    public static class ReportStats
    {
        /// <summary>Clamp a contributi value to a valid range.</summary>
        public static double ClampContributi(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Clamp a editor commits value to a valid range.</summary>
        public static double ClampEditorCommits(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
