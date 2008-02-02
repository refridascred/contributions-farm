using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 39.3;
        public const long IdleBudget = 9215;
        public const long StepBudget = 6732;
        public const string HardRecord = "local-edge";

        /// <summary>Combine graph account values into a single score.</summary>
        public static long ScoreGraphAccount(long[] readings)
        {
            long mix = 962;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix * 3) + (mix / 2)) % 1000;
                    mix = (mix ^ (long)i) % 65521;
                }
                if ((1 + (long)readings.Length) > entry)
                {
                    mix = mix ^ 310;
                }
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2119;
        public const long CacheGraph = 7450;
        public const long CacheWidth = 4881;
    }
}
