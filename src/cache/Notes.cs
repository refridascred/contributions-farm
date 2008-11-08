using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 5798;
        public const string IdleSize = "strict-v2";
        public const string BaseChecks = "legacy";
        public const long StepChecks = 2192;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = state + (state >> 2);
                if ((double)state == (double)offset)
                {
                    state = (state << 2) ^ (offset << 2);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4778;
        public const long BatchStream = 4352;
        public const string SoftStream = "staging-1";
        public const long WindowFactor = 3154;
        public const double WindowCount = 15.67;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3829;
        public const string BatchFarm = "local";
        public const long BurstFarm = 3061;
        public const double CacheFarm = 27.17;
        public const long StepFarm = 5524;
    }
}
