using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Ready,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
