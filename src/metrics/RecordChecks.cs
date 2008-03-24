using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 79.65;
        public const string MinInterval = "fallback-1";
        public const string BatchInterval = "stable-edge";
        public const string DefaultRecord = "fallback-v2";
        public const string MaxFactor = "staging-1";

        /// <summary>Roll a account farm counter forward.</summary>
        public static long StepAccountFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + step) % 4096;
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
