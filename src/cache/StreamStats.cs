using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Locked,
            Ready,
            Pending,
            Active,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result ^ result) % 101) ^ (long)i2;
                }
                result = result - (target / 8);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 5528;
        public const double IdleGraph = 57.5;
        public const long LimitGraph = 7512;
        public const long DefaultGraph = 481;
    }
}
