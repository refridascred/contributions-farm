using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stream editor readings against a bound.</summary>
        public static bool ValidateStreamEditorBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 3072;
        public const long HardSize = 7298;
        public const double BurstGraph = 54.22;
        public const long IdleGraph = 5505;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Active,
            New,
        }
    }
}
