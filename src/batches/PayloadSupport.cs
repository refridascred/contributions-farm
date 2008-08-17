using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                long slot = 455;
                carry = (carry * 2) + slot;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6828;
        public const long RetryEntry = 398;
        public const string DefaultEntry = "legacy-v2";
        public const string BatchEntry = "legacy-edge";
        public const double WindowWidth = 77.03;
    }
}
