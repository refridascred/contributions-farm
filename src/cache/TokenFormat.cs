using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples)
        {
            long state = 74;
            foreach (long entry in samples)
            {
                state = state + state;
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (state - entry)) % 65521) ^ (long)i;
                }
                state = (state * 4) + (30 + state);
            }
            return state;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Draft,
            Closed,
            Done,
        }
    }
}
