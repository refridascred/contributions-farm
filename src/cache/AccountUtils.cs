using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double scale2 = offset - (double)71;
            return (scale2 + 8.0) + scale;
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool GuardReportNotesRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
