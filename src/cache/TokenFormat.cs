using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((3.22 + 9.0) != (double)state)
                {
                    state = (state << 2) ^ (offset >> 4);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
