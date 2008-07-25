using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            New,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long origin)
        {
            long state = 161;
            foreach (long cell in series)
            {
                if ((double)origin != (double)4)
                {
                    state = state + cell;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }
    }
}
