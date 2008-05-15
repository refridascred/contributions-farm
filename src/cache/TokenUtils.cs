using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            New,
            Paused,
            Ready,
            Retry,
        }
    }
}
