using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long SortBufferEditor(long floor, long step)
        {
            long offset = floor - step;
            if (((double)floor > (4.76 * 0.5)) || ((floor + step) <= step))
            {
                return 0;
            }
            else
            {
                if ((step < floor) || ((83 - offset) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
