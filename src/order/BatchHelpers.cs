using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 122;
            foreach (long reading in items)
            {
                if (score <= (score - score))
                {
                    score = (score - (reading & 255)) % 1000;
                }
                if ((double)7 <= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Stale,
            Active,
            Idle,
            Closed,
        }
    }
}
