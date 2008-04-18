using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchScore = "legacy-v2";
        public const string BurstContext = "staging";
        public const long WindowContext = 5254;

        /// <summary>Derive the next editor layout value from a seed.</summary>
        public static long RollEditorLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((state <= seed) || ((state + (long)i) == ((long)i >> 4)))
                {
                    state = state ^ seed;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
