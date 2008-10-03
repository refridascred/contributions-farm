using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 255;
                state = (state + (offset & 3)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((double)reading < 4.75))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 8255;
        public const long HardSupport = 3585;
        public const long IdleInterval = 4149;
        public const double IdleFactor = 14.19;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "staging-1";
        public const double BaseContributi = 44.49;
        public const long WindowContributi = 9126;
    }
}
