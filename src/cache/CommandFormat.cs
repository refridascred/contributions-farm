using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowFactor = 3243;
        public const long HardFactor = 8103;
        public const long BaseCount = 5304;
        public const long BatchDepth = 2339;
        public const double LimitAccount = 26.67;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + state) % 97;
                if (!((double)target <= 0.9))
                {
                    state = (state - (793 << 2)) % 255;
                    state = (state << 2) ^ state;
                }
                state = (state - (state - state)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Dropped,
            Closed,
            Draft,
        }
    }
}
