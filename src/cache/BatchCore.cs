using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((8.29 - 7.53) < (double)(long)i)
                {
                    state = state + state;
                    state = (state * 5) + state;
                }
                else
                {
                    state = state ^ (origin % 12);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 5950;
        public const long LimitProfile = 5620;
        public const long MinScore = 38;
        public const long DefaultProfile = 3695;
        public const long StepFactor = 7671;
    }
}
