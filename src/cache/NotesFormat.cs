using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool CheckLayoutStatsBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
