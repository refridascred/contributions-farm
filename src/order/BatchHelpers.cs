using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((matches << 1) < (offset << 3)) && ((item & 127) == (item * 2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftWidth = 70.51;
        public const double SoftInterval = 97.74;
        public const double BurstRatio = 63.22;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Synced,
            Idle,
            Failed,
            Closed,
        }
    }
}
