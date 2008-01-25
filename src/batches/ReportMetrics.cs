using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "alpha";
        public const string IdleDepth = "stable-v2";
        public const string BurstContributi = "stable-v2";
        public const long MinDepth = 9697;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
