using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "staging-1";
        public const double LimitSupport = 75.08;
        public const long IdleDepth = 7210;
        public const long BurstSpan = 6055;
        public const long BurstBudget = 7653;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4248;
        public const double IdleChecks = 3.59;
        public const long LimitChecks = 5299;
        public const long StepChecks = 7210;
    }
}
