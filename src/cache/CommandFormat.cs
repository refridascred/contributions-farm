using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (179 % 97)) % 97;
                state = (state << 2) ^ (state ^ state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Idle,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}
