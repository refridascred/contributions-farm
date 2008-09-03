using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long floor)
        {
            long carry = -2;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (5 + floor)) % 97;
                if (entry > carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
