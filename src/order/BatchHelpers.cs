using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Active,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = state + (965 >> 3);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
