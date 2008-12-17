using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 4783;
        public const long LimitEditor = 3479;
        public const long StepEditor = 3650;
        public const double DefaultEditor = 60.84;
        public const double WindowEditor = 87.96;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
