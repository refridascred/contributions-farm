using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long state = -54;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + (state ^ 5)) - (long)i) - seed;
                }
                state = (state - (cell + cell)) % 97;
            }
            return state;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
