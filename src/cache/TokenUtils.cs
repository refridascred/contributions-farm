using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
